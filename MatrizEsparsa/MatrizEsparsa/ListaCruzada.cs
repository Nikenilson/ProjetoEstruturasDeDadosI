﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

///======================================
/// Samuel Gomes de Lima Dias - 18169   =
/// Guilherme Salim de Barros - 18188   =
///======================================

namespace MatrizEsparsa
{
    class ListaCruzada
    {
        private Celula primeiroCabeca, atual, esquerda, acima;
        int linhas, colunas;

        public Celula PrimeiroCabeca { get => primeiroCabeca; }

        public ListaCruzada()
        {
            primeiroCabeca = null;
        }

        public ListaCruzada(int m, int n)
        {
            linhas = m;
            colunas = n;

            primeiroCabeca = new Celula(-1, -1, 0);
            Celula percorre = primeiroCabeca; // ponteiro usado para percorrer, inicia no primeiro valor da matriz

            Celula proximaLinha;   // representa a célula da proxima linha, após a variável "percorre"
       
            for (int i = 0; i < linhas; i++)

            {
                proximaLinha = new Celula(i, -1, 0); // "proximaLinha" é (re)instanciada como uma nova célula com a linha correspondente ao índice,
                                                     // coluna -1 e valor 0 (já que não existe valor específico a ser inserido)

                percorre.Abaixo = proximaLinha;    // célula abaixo do "percorre" recebe "proximaLinha", ligando-os

                percorre.Direita = percorre;       // já que, por enquanto, só há um elemento por linha, a célula a direita de "percorre" é ele mesmo

                percorre = percorre.Abaixo;     // "percorre" avança para o elemento a baixo
            }

            percorre.Abaixo = primeiroCabeca;  // como chegamos no último elemento em relação às linhas, o abaixo de percorre é o primeiro
            percorre.Direita = percorre;    // já que, por enquanto, só há um elemento por linha (com execão da -1),
                                            // a célula a direita de "percorre" é ele mesmo

            percorre = primeiroCabeca; // faremos quase o mesmo processo realizado anteriormente para as colunas, 
                                       // para isso devemos fazer "percorre" receber o primeiro valor da lista



            Celula proximaColuna;   // representa a célula da proxima coluna, após a variável "percorre"

            for (int i = 0; i < colunas; i++)
            {
                proximaColuna = new Celula(-1, i, 0); // "proximaLinha" é (re)instanciada como uma nova célula com a linha correspondente ao índice,
                                                      // coluna -1 e valor 0 (já que não existe valor específico a ser inserido)
  
                percorre.Direita = proximaColuna;        // a célula a baixo de "percorre" é ele mesmo


                percorre.Abaixo = percorre;       // já que, por enquanto, só há um elemento por coluna (com execão da -1), 
                                                  // a célula abaixo do "percorre" recebe "proximaLinha", ligando-os

                percorre = percorre.Direita;     // "percorre" avança para o elemento a direita
            }

            percorre.Direita = primeiroCabeca;   // como chegamos no último elemento em relação às colunas, o a direita de percorre  é o primeiro 
            percorre.Abaixo = percorre;  // já que, por enquanto, só há um elemento por linha, a célula a abaixo de "percorre" é ele mesmo

        }
        public bool EstaVazia
        {
            get => acima == null || esquerda ==null;
        }

        public bool ExisteCelula(int linha, int coluna) //Procura uma célula da lista e retorna verdadeiro ou falso vaso ache ou não
        {
            esquerda = primeiroCabeca;  // inicializamos esquerda com a "cabeça" da matriz
            acima = primeiroCabeca;     // inicializamos direita também com a "cabeça" da matriz

            for (int l = 1; l <= linha; l++)    // percorremos todas as linhas "cabeça" da matriz
                acima = acima.Abaixo;

            for (int c = 1; c <= coluna; c++)   // percorremos todas as colunas "cabeça" da matriz
                esquerda = esquerda.Direita;

            while (esquerda.Direita.Coluna != -1 && esquerda.Direita.Coluna < coluna)     // enquanto a coluna do à direita da célula "esquerda" for diferente de -1, ou seja,
                esquerda = esquerda.Direita;                                             // não for uma coluna "cabeça" e for menor que a coluna buscada, "esquerda" recebera a célula à direita

            while (acima.Abaixo.Linha != -1 && acima.Abaixo.Linha < linha)  // enquanto a linha do à direita da célula "acima" for diferente de -1, ou seja,
                acima = acima.Abaixo;                               // não for uma linha "cabeça" e for menor que a coluna buscada, "acima" recebera a célula abaixo

            if (esquerda.Direita.Linha == linha && acima.Abaixo.Coluna == coluna)
                if (esquerda.Direita.Valor == acima.Abaixo.Valor) 
                    return true;

            

            return false;
        }

        public double AcessarValor(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0)    //Se a linha ou coluna forem menor que 0, são inválidas, sendo assim se lança uma exceção
                throw new Exception("Linha e/ou coluna inválida(s)");

            if (ExisteCelula(linha, coluna)) //Se a celula existe, retorna o seu valor 
                return esquerda.Direita.Valor;

            return 0; //Se nao existe, retorna o valor padrao, 0
        }

        public void InserirCelula(int linha, int coluna, double valorNovo)
        {
            if (ExisteCelula(linha, coluna)) //Se ja existe uma celula nessa possição, "altera" o valor antigo
                acima.Abaixo.Valor = valorNovo;
            else
            {
                Celula celulaNova = new Celula(linha, coluna, valorNovo);

                //Inclui a celula no meio das linhas e colunas da Lista, no lugar desejado
                celulaNova.Direita = esquerda.Direita;
                esquerda.Direita = celulaNova;

                celulaNova.Abaixo = acima.Abaixo;
                acima.Abaixo = celulaNova;

            }
        }

        public void ExcluirCelula(int linha, int coluna)  // método de exclusão com linha e coluna sendo os parâmetros
        {
            if (ExisteCelula(linha, coluna)) 
            {
                acima.Abaixo = atual.Abaixo;
                esquerda.Direita = atual.Direita;
            }

        }

        public void ExcluirCelula(Celula aExcluir)  // método de exclusão com célula sendo o parâmetro
        {
            if (ExisteCelula(aExcluir.Linha, aExcluir.Coluna))
            {
                acima.Abaixo = atual.Abaixo;
                esquerda.Direita = atual.Direita;
            }

        }

        public void SomarK(int coluna, double k) //Soma a constante k a uma coluna
        {
            atual = primeiroCabeca;
            for (int i = 0; i < coluna; i++) // percorre a lista ate a coluna desejada
            {
                if (atual.Direita.Coluna > coluna) //Se a proxima linha for maior que a desejada, a linha nao tem nenhum no e portanto deve ser criada, 
                    for (int e = 0; e < linhas; e++)
                        InserirCelula(e, coluna, k);

                if (atual.Coluna == coluna) 
                while (!(atual.Valor == -1)) //Enquanto não chegou na celula cabeça
                {
                    atual.Valor = atual.Valor + k; //Soma a constante

                    if (atual.Valor == 0) //Se o valor se tornar 0, a celula não eh mais necessaria, pode ser excluida
                        ExcluirCelula(atual.Linha,atual.Coluna); 
                    atual = atual.Abaixo;
                }
                atual = atual.Direita;
            }

        }

        public void DesalocarMemoria() //Desaloca os ponteiros da ListaCruzada
        {
            atual = null;
            esquerda = null;
            acima = null;
            primeiroCabeca = null;
        }

        public void Exibir(ref DataGridView dgv) //Exibe a ListaCruzada em um DataGridView
        {
            //Deixa o gridView do tamanho da ListaCruzada 
            dgv.RowCount = linhas;
            dgv.ColumnCount = colunas;

            //Preenche o gridView com zeros para representar as posições vazias
            foreach (DataGridViewRow row in dgv.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = 0;

            //Percorre a ListaCruzada para preencher o gridView com os valores armazenados
            atual = primeiroCabeca.Abaixo.Direita;
            atual.Valor = atual.Valor;
            while(atual.Linha != -1)
            {   
                while (atual.Coluna != -1)
                {
                    dgv.Rows[atual.Linha].Cells[atual.Coluna].Value = atual.Valor;
                    atual = atual.Direita;       
                }
                atual = atual.Direita.Abaixo;
            }
        }

        
        public ListaCruzada MultiplicarMatrizes(ListaCruzada lista1, ListaCruzada lista2)
        {
            if (lista1.colunas != lista2.linhas) // caso o número de colunas da primeira matriz seja diferente do de linhas da segunda, 
                                                 // não será possível realizar a operação e uma exeção será lançada.
                throw new Exception("O número de colunas da primeira matriz é diferente do de linhas da segunda!");

            ListaCruzada listaResultado = new ListaCruzada();
            for(int iLinha1 = 0; iLinha1 < lista1.linhas; iLinha1++) // enquanto a vaiável "iLinha", a qual representa a linha atual da 1ª matriz,
                                                                    // for menor que a quantidade de linhas dessa matriz
            {
                
                int iColuna2 = iLinha1;  // a variável "iColuna2" representa a coluna atual da 2ª matriz, sempre se igualando a "iLinha" quando ela muda
                

                for (int iLinha2 = 0; iLinha2 < lista2.linhas; iLinha2++)// enquanto a vaiável "iLinha2", a qual representa a linha atual da 2ª matriz,
                                                         // for menor que a quantidade de linhas dessa matriz
                {
                    double resultado = 0;  // declaração da variável local do tipo  double "resultado", recebendo 0;

                    for (int iColuna1 = 0; iColuna1 < lista1.colunas; iColuna1++) // enquanto a vaiável "iColuna", a qual representa a coluna atual da 1ª matriz,
                                                                                  // for menor que a quantidade de colunas dessa matriz
                    {
                        // resultado somará a ele mesmo o resultado da multiplicação do valor da célula da 1ª matriz de linha e coluna
                        // iguais a suas variáveis correspondentes ("iLinha1" e "iColuna1") com a célula da segunda matriz de linha e coluna correspondentes
                        // às vaiáveis "iLinha2" e "iColuna2"
                        resultado += lista1.AcessarValor(iLinha1, iColuna1) * lista2.AcessarValor(iLinha2, iColuna2);
                    
                    }
                    // quando todas as colunas, da linha atual da primeira matriz, multiplicarem as células de todas as linhas da primeira coluna,
                    // resultado inserirá uma nova célula com valor igual a resultado
                    listaResultado.InserirCelula(iLinha1, iColuna2, resultado);
                }
            }
            return listaResultado;
        }

        public ListaCruzada SomarMatrizes(ListaCruzada lista1, ListaCruzada lista2)
        {
            if (lista1.linhas != lista2.linhas || lista1.colunas != lista2.colunas)
                throw new Exception("O número de linhas e colunas da primeira matriz é diferente da segunda!");

            ListaCruzada ret = new ListaCruzada();

            //Percorre as duas matrizes, somando os valores e colocando os resultados em uma ListaCruzada a ser retornada 
            for (int i = 0; i < lista1.linhas; i++)
                for (int e = 0; e < lista1.colunas; e++)
                    ret.InserirCelula(i, e, lista1.AcessarValor(i, e) + lista2.AcessarValor(i, e));
            //Retorna a Matriz Resultante da soma
            return ret;
        }
 
    }
}


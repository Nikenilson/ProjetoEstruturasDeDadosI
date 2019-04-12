using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

///
/// Samuel Gomes de Lima Dias - 18169
/// Guilherme Salim de Barros - 18188
///

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
       
            for (int i = 1; i <= linhas; i++)

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

            for (int i = 1; i <= colunas; i++)
            {
                proximaColuna = new Celula(i, -1, 0); // "proximaLinha" é (re)instanciada como uma nova célula com a linha correspondente ao índice,
                                                      // coluna -1 e valor 0 (já que não existe valor específico a ser inserido)

                if (i != 0)                              // caso o índice não seja 0, e "percorre", consequentemente, não seja o primeiro valor da lista,  
                    percorre.Abaixo = percorre;        // a célula a baixo de "percorre" é ele mesmo


                percorre.Direita = proximaColuna;       // já que, por enquanto, só há um elemento por coluna (com execão da -1), 
                                                        // a célula abaixo do "percorre" recebe "proximaLinha", ligando-os

                percorre = percorre.Direita;     // "percorre" avança para o elemento a direita
            }


            percorre.Direita = primeiroCabeca;   // como chegamos no último elemento em relação às colunas, o a direita de percorre  é o primeiro 
            percorre.Abaixo = percorre;  // já que, por enquanto, só há um elemento por linha, a célula a direita de "percorre" é ele mesmo

        }

        public bool EstaVazia
        {
            get => acima == null || esquerda ==null;
        }


        public bool ExisteCelula(int linha, int coluna) //Procura e retorna uma Celula da Lista 
        {
            esquerda = primeiroCabeca;
            acima = primeiroCabeca;
            for (int l = 1; l <= linha; l++)
                acima= acima.Abaixo;
            for (int c = 1; c <= coluna; c++)
                esquerda = esquerda.Direita;
            while (esquerda.Direita.Coluna != -1 && esquerda.Direita.Coluna < coluna)
                esquerda = esquerda.Direita;
            while (acima.Abaixo.Linha != -1 && acima.Abaixo.Linha < linha)
                acima = acima.Abaixo;

            if (esquerda.Direita.Linha == linha && acima.Abaixo.Coluna == coluna)
                if (esquerda.Direita.Valor == acima.Abaixo.Valor) 
                    return true;

            

            return false;
        }


        public double AcessarValor(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0)    // se a linha ou coluna forem menor que 0, são inválidas, sendo assim se lança uma exceção
                throw new Exception("Linha e/ou coluna inválida(s)");

            if (ExisteCelula(linha, coluna))
                return esquerda.Direita.Valor;

            return 0; //Se nao existe, retorna o valor padrao, 0
        }

        public void InserirCelula(int linha, int coluna, double valorNovo)
        {

            if (ExisteCelula(linha, coluna))
                acima.Abaixo.Valor = valorNovo;
            else
            {
                ExisteCelula(linha, coluna);
                Celula celulaNova = new Celula(linha, coluna, valorNovo);

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

        public void Exibir(ref DataGridView a) //Exibe a ListaCruzada em um DataGridView
        {
            a.Columns.Clear();
            a.Rows.Clear();
            for (int i = 1; i < this.linhas; i++)
                a.Columns.Add(i.ToString(), i.ToString());

            string[] linha = new string[colunas];
            for (int i = 1; i < linhas; i++)
            {
                for (int e = 0; e < colunas; e++)
                    linha[e] = AcessarValor(i, e).ToString();
                a.Rows.Add(linha[i]);
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

            for (int i = 0; i < lista1.linhas; i++)
                for (int e = 0; e < lista1.colunas; e++)
                    ret.InserirCelula(i, e, lista1.AcessarValor(i, e) + lista2.AcessarValor(i, e));
  
            return ret;
        }
 
    }
}
///Feito
///
///• Criar a estrutura básica da matriz esparsa com dimensão M x N 
///• Retornar o valor de uma posição (l, c) da matriz 
///• Inserir um novo elemento em uma posição (l, c) da matriz
///• Remover o elemento (l,c) da matriz
///• Somar a constante K a todos os elementos da coluna c da matriz 
///• Liberar todas as posições alocadas da matriz, incluindo sua estrutura básica
///• Ler um arquivo texto com as coordenadas e os valores não nulos, armazenando-os na matriz 
/// • Exibir a matriz na tela, em um gridView
/// • Multiplicar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas exibidas em seu próprio gridView. 
///O resultado deve gerar uma nova estrutura de matriz esparsa e exibido em um gridview próprio
///• Somar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas exibidas em seu próprio gridView.
///O resultado deve gerar uma nova estrutura de matriz esparsa e exibido em um gridview próprio
/// Feito, mas nao testado
/// 
/// Falta 
/// 
/// 
///
///Tambem tomar cuidado com 
///
/// •quando um elemento da matriz deixar de ser nulo, há inserção na estrutura 
/// •quando um elemento da matriz se torna nulo, há sua remoção da estrutura.

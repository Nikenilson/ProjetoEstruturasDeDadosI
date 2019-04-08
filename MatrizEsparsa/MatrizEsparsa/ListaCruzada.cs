﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

///
/// Samuel Gomes de Lima Dias - 18169
/// Guilherme Salim de Barros - 18188
///

namespace MatrizEsparsa
{
    class ListaCruzada
    {
        private Celula primeiroCabeca, atual, anterior;
        private int quantosValores;
        int linhas, colunas;
        
        public Celula PrimeiroCabeca { get => primeiroCabeca; }

        public ListaCruzada()
        {
            primeiroCabeca = null;
            quantosValores = 0;
        }

        public ListaCruzada(int m, int n)
        {


            linhas = m;
            colunas = n;

            primeiroCabeca = new Celula(-1, -1, 0);
            Celula percorre = primeiroCabeca; // ponteiro usado para percorrer, inicia no primeiro valor da matriz

            Celula proximaLinha;   // representa a célula da proxima linha, após a variável "percorre"

            for(int i = 0; i < linhas; i++)
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
                proximaColuna = new Celula(i, -1, 0); // "proximaLinha" é (re)instanciada como uma nova célula com a linha correspondente ao índice,
                                                      // coluna -1 e valor 0 (já que não existe valor específico a ser inserido)

                if(i != 0)                              // caso o índice não seja 0, e "percorre", consequentemente, não seja o primeiro valor da lista,  
                    percorre.Abaixo = percorre;        // a célula a baixo de "percorre" é ele mesmo
                

                percorre.Direita = proximaColuna;       // já que, por enquanto, só há um elemento por coluna (com execão da -1), 
                                                   // a célula abaixo do "percorre" recebe "proximaLinha", ligando-os

                percorre = percorre.Direita;     // "percorre" avança para o elemento a direita
            }

            
            percorre.Direita = primeiroCabeca;   // como chegamos no último elemento em relação às colunas, o a direita de percorre  é o primeiro 
            percorre.Abaixo = percorre;  // já que, por enquanto, só há um elemento por linha, a célula a direita de "percorre" é ele mesmo


            /*primeiro = new Celula();
            atual = new Celula();
            anterior = primeiro;
            primeiro.Abaixo = atual; 

            for (int i = 0; i < m + 1; i++)//Gera os nos cabeça das linhas
            {
                atual.Abaixo = new Celula();
                atual.Direita = atual;
                atual.Valor = -1;
                atual.Linha = i;
                anterior = atual;
                atual = atual.Abaixo;
            }
            atual.Abaixo = primeiro; //Garante a circularidade da lista

            
            atual = primeiro;
            for(int i = 0; i < n + 1; i++)//Gera os nos cabeça das colunas
            {
                atual.Direita = new Celula();
                atual.Abaixo = atual;
                atual.Valor = -1;
                atual.Coluna = i;
                anterior = atual;
                atual = atual.Direita;
            }
            atual.Direita = primeiro; //Garante a circularidade da lista*/
        }

        public bool EstaVazia
        {
            get => primeiroCabeca == null;
        }

        public void Inserir()
        {

        }

        public void Remover()
        {
            
        }


        public bool ExisteCelula(int linha, int coluna) //Procura e retorna uma Celula da Lista 
        {
            atual = primeiroCabeca;

            for (int i = 0; i < linha; i++) //Posiciona atual na linha desejada
            {
                if (atual.Linha > linha)//Se a linha atual for maior que a desejada, a celula nao existe, retorna falso
                    return false;

                anterior = atual;
                atual = atual.Abaixo;
            }
            while (true) //Percorre a linha ate chegar na coluna desejada 
            {
                if (atual.Coluna == coluna)
                    return true;

                if (atual.Coluna > coluna) //Se a coluna atual for maior que a desejada, a celula nao existe, sai do while e retorna falso
                    break;

                anterior = atual;
                atual = atual.Direita;
            }
            return false;
        }


        public double AcessarValor(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0)    // se 
                throw new Exception("Linha e/ou coluna inválida(s)");

            if (ExisteCelula(linha, coluna))
                return atual.Valor;

            return 0;
        }

       /* public bool ExisteCelula(Celula cell)
        {

            // cell é a respresentação da célula procurada

            atual = primeiro;
     
            for (int i = 0; i < cell.Linha; i++) //Posiciona atual na linha desejada
            {
                if (atual.Linha > cell.Linha)//Se a linha atual for maior que a desejada, a celula nao existe, retorna falso
                    return false;

                anterior = atual;
                atual = atual.Abaixo;
            }
            while (true) //Percorre a linha ate chegar na coluna da célula procurada
            {
                if (atual.Coluna == cell.Coluna)
                    if (atual.Valor == cell.Valor) // se o valor de atual for igual ao da célula procurada, retorna true
                        return true;

                if (atual.Coluna > cell.Coluna) //Se a coluna atual for maior que a da célula procurada, a celula nao existe, sai do while e retorna falso
                    break;

                anterior = atual;
                atual = atual.Direita;
            }
            return false;
        }*/

        public void InserirCelula(Celula celulaProcurada)
        {
            
            if(ExisteCelula(celulaProcurada.Linha, celulaProcurada.Coluna))
            {
                celulaProcurada.Direita = atual.Direita;
                celulaProcurada.Abaixo = atual.Abaixo;
                anterior.Abaixo = celulaProcurada;
            }
            else
            {
                int anteriorLinha = anterior.Abaixo.Linha;
                int anteriorColuna = anterior.Coluna;
            }
            
        }


        public void OperacaoLinhaColuna(int n, bool linhaColuna, double k, bool operador)
        {
            //n representa a linha/coluna desejada
            //k e a constante a ser somada ou multiplicada

            //se linhaColuna == true, a operacao deve ser aplicada a uma LINHA
            //se nao, deve ser aplicada a uma COLUNA

            //se operador == true, a operacao deve ser SOMA
            //se nao, deve ser MULTIPLICACAO
            if (!(n < 0))//se N e menor que 0, nada precisa ser feito, pois nao ha colunas negativas
            {
                atual = primeiroCabeca;

                if (linhaColuna) //Se true, a operacao deve ser aplicada uma linha
                {
                    for (int i = 0; i < n; i++) // percorre a lista ate a linha desejada
                    {
                       // if (atual.Abaixo.Linha > n) //Se a proxima linha for maior que a desejada, a linha nao tem nenhum no e portanto deve ser criada, 
                                // Incluir(numero, i ,k);

                            atual = atual.Abaixo;

                        if (atual.Linha == n)
                            while (!(atual.Valor == -1))
                            {
                                if(operador)//Se verdadeiro,Soma
                                    atual.Valor = atual.Valor + k;
                                else//se nao multiplica
                                    atual.Valor = atual.Valor * k;

                                if (atual.Valor == 0)
                                    //Remover(atual);

                                atual = atual.Direita;
                            }
                    }
                }
                else //Deve ser aplicada em uma coluna
                {
                    for (int i = 0; i < n; i++) // percorre a lista ate a linha desejada
                    {
                        // if (atual.Direita.Coluna > n) //Se a proxima linha for maior que a desejada, a linha nao tem nenhum no e portanto deve ser criada, 
                        // Incluir(numero, i ,k);

                        atual = atual.Direita;
                        if (atual.Coluna == n)
                            while (!(atual.Valor == -1))
                            {
                                if (operador)//Se verdadeiro,Soma
                                    atual.Valor = atual.Valor + k;
                                else//se nao multiplica
                                    atual.Valor = atual.Valor * k;

                                if (atual.Valor == 0)
                                    //Remover(atual);

                                    atual = atual.Abaixo;
                            }
                    }
                }

            }
        }

    }
}
///*
///Feito, mas nao testado
///
///• Criar a estrutura básica da matriz esparsa com dimensão M x N 
///• Retornar o valor de uma posição (l, c) da matriz 
///• Somar a constante K a todos os elementos da coluna c da matriz (Precisa de algumas alteracoes para seguir as exigencias do "Tambem tomar cuidado com")
///
/// Nossa Prioridade
/// • Inserir um novo elemento em uma posição (l, c) da matriz
/// • Remover o elemento (l,c) da matriz 
/// • Ler um arquivo texto com as coordenadas e os valores não nulos, armazenando-os na matriz 
/// • Exibir a matriz na tela, em um gridView 
///
/// Falta 
/// • Liberar todas as posições alocadas da matriz, incluindo sua estrutura básica 
/// • Somar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas exibidas em seu próprio gridView.
///O resultado deve gerar uma nova estrutura de matriz esparsa e exibido em um gridview próprio 
/// • Multiplicar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas exibidas em seu próprio gridView. 
///O resultado deve gerar uma nova estrutura de matriz esparsa e exibido em um gridview próprio 
///
///Tambem tomar cuidado com 
///
/// •quando um elemento da matriz deixar de ser nulo, há inserção na estrutura 
/// •quando um elemento da matriz se torna nulo, há sua remoção da estrutura.

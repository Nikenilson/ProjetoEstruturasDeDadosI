using System;
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
        private Celula primeiro, primeiroCabeca;
        private int quantosValores;

        public Celula Primeiro { get => primeiro; }
        public Celula PrimeiroCabeca { get => primeiroCabeca; }

        public ListaCruzada()
        {
            primeiro = null;
            quantosValores = 0;
        }

        public ListaCruzada(int m, int n)
        {
            primeiro = new Celula();
            Celula atual = new Celula();
            primeiro.Abaixo = atual; 

            for (int i = 1; i < m + 1; i++)//Gera os nos cabeça das linhas
            {
                atual.Abaixo = new Celula();
                atual.Direita = atual;
                atual.Valor = -1;
                atual.Linha = i;
                atual = atual.Abaixo;
            }
            atual.Abaixo = primeiro; //Garante a circularidade da lista

            atual = primeiro;
            for(int i = 1; i < n + 1; i++)//Gera os nos cabeça das colunas
            {
                atual.Direita = new Celula();
                atual.Abaixo = atual;
                atual.Valor = -1;
                atual.Coluna = i;
                atual = atual.Direita;
            }
            atual.Direita = primeiro; //Garante a circularidade da lista
        }

        public bool EstaVazia
        {
            get => primeiro == null;
        }

        public void Inserir()
        {

        }

        public void Remover()
        {
            
        }


        public Object ExisteCelula(int linha, int coluna) //Procura e retorna uma Celula da Lista 
        {
            Celula atual = primeiro;

            for (int i = 0; i < linha; i++) //Posiciona atual na linha desejada
            {
                if (atual.Linha > linha)//Se a linha atual for maior que a desejada, a celula nao existe, retorna falso
                    return false;

                atual = atual.Abaixo;
            }
            while(true) //Percorre a linha ate chegar na coluna desejada 
            {
                if (atual.Coluna == coluna)
                    return atual.Valor;

                if (atual.Coluna > coluna) //Se a coluna atual for maior que a desejada, a celula nao existe, sai do while e retorna falso
                    break;

                atual = atual.Direita;
            }
            return false;
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
                Celula atual = primeiro;

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

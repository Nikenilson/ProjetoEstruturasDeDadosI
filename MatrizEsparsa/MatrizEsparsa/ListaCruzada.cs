using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            atual.Abaixo = primeiro;

            atual = primeiro;
            for(int i = 1; i < n + 1; i++)//Gera os nos cabeça das colunas
            {
                atual.Direita = new Celula();
                atual.Abaixo = atual;
                atual.Valor = -1;
                atual.Coluna = i;
                atual = atual.Direita;
            }
            atual.Direita = primeiro;
        }

        public bool EstaVazia
        {
            get => primeiro == null;
        }

        public Object ExisteDado(int linha, int coluna)
        {
            Celula atual = primeiro;

            for (int i = 0; i < linha; i++)
            {
                if (atual.Linha > linha)
                    return false;
                atual = atual.Abaixo;
            }
            for (int e = 0; e < coluna; e++)
            {
                if (atual.Coluna == e)
                    return atual.Valor;

                if (atual.Coluna > coluna)
                    break;

                atual = atual.Direita;
            }
            return false;
        }

        public void OperacaoLinhaColuna(int n, bool linhaColuna, double k, bool operador)
        {
            if (!(n < 1))
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
///• Somar a constante K a todos os elementos da coluna c da matriz 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class Celula
    {
        Celula direita, abaixo;
        int linha, coluna;
        double valor;

        public int Linha { get => linha; set => linha = value; }
        public int Coluna { get => coluna; set => coluna = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Celula Direita
        {
            get => direita;
            set
            {
                if (direita.Valor != 0)
                    direita = value;
            }
        }

        internal Celula Abaixo
        {
            get => abaixo;
            set
            {
                if (abaixo.Valor != 0)
                    abaixo = value;
            }
        }
    }
}

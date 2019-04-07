using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Samuel Gomes de Lima Dias - 18169
/// Guilherme Salim de Barros - 18188
///

namespace MatrizEsparsa
{
    class Celula
    {
        Celula direita, abaixo;
        int linha, coluna;
        double valor;

        public Celula(Celula outraDireita, Celula outraAbaixo, int outraLinha, int outraColuna, double outroValor)
        {
            if (outraAbaixo == null || outraColuna == 0 || outraDireita == null || outraLinha == 0)
                throw new Exception("Um ou mais valores inválidos");


            direita = outraDireita;
            abaixo = outraAbaixo;
            linha = outraLinha;
            coluna = outraColuna;
            valor = outroValor;


            // O Chico não gosta que coloque this, né?
        }

        public Celula(int outraLinha, int outraColuna, double outroValor)
        {
            if (outraColuna == 0 ||  outraLinha == 0)
                throw new Exception("Um ou mais valores inválidos");

            linha = outraLinha;
            coluna = outraColuna;
            valor = outroValor;


            // O Chico não gosta que coloque this, né?
        }

        public Celula()
        {
            direita = null;
            abaixo = null;
            valor = 0;
        }

        public int Linha { get => linha; set => linha = value; }

        public int Coluna { get => coluna; set => coluna = value; }

        public double Valor { get => valor; set => valor = value; }

        internal Celula Direita
        {
            get => direita;
            set => direita = value;
        }

        internal Celula Abaixo
        {
            get => abaixo;
            set => abaixo = value;
        }
    }
}

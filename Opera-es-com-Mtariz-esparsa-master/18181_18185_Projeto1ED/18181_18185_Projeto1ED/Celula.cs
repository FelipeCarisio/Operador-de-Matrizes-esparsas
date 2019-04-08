using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Celula
   {
        Celula celulaDireita = null, celulaBaixo = null;
        int coluna = 0, linha = 0;
        double valor = default(Double);

        public Celula(Celula direito, Celula baixo, int col, int lin, double val)
        {
            this.celulaDireita = direito;
            this.celulaBaixo = baixo;
            this.coluna = col;
            this.linha = lin;
            this.valor = val;
        }

        public int Coluna { get => coluna; set => coluna = value; }
        public int Linha { get => linha; set => linha = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Celula CelulaDireita { get => celulaDireita; set => celulaDireita = value; }
        internal Celula CelulaBaixo { get => celulaBaixo; set => celulaBaixo = value; }
   }
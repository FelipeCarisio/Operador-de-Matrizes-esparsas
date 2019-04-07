using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _18181_18185_Projeto1ED
{
    class MatrizEsparsa
    {
        int linhas = 0, colunas = 0,
            qtdElementos = 0;

        Celula celulaAtual = null, ultimaCelula = null, primeiraCelula = null, celulaAnterior = null, celulaCabecalhoCol = null, celulaCabecalhoLin = null;

        public MatrizEsparsa(int col, int lin)
        {
            this.linhas = lin;
            this.colunas = col;

            this.primeiraCelula = new Celula(null, null, 0, 0, 0);
            this.celulaAtual = this.primeiraCelula;

            for(int i = 0; i < linhas; i++)
            {
                if (i == 0)
                {
                    for (int a = 0; a < colunas; a++)
                    {
                        Celula cabecalho = new Celula(null, null, a, i, 0);
                        this.celulaAtual.CelulaDireita = cabecalho;
                        this.celulaAtual = this.celulaAtual.CelulaDireita;
                    }

                    this.celulaAtual = this.primeiraCelula;
                }
                else
                {
                    Celula cabecalho = new Celula(null, null, 0, i, 0);
                    this.celulaAtual.CelulaBaixo = cabecalho;
                    this.celulaAtual = this.celulaAtual.CelulaBaixo;
                }
            }
        }

        public int Linhas { get => linhas; set => linhas = value; }
        public int Colunas { get => colunas; set => colunas = value; }
        public int QtdElementos { get => qtdElementos; set => qtdElementos = value; }
        public Celula CelulaAtual { get => celulaAtual; set => celulaAtual = value; }
        public Celula UltimaCelula { get => ultimaCelula; set => ultimaCelula = value; }
        public Celula PrimeiraCelula { get => primeiraCelula; set => primeiraCelula = value; }
        public Celula CelulaAnterior { get => celulaAnterior; set => celulaAnterior = value; }

        public Celula Buscar(int lin, int col)
        {
            celulaAtual = PrimeiraCelula;
            for(int i = celulaAtual.Linha; i <= lin; i = celulaAtual.Linha)
            {
                celulaAtual = celulaAtual.CelulaBaixo;
            }

            for(int i = celulaAtual.Coluna; i <= col; i = celulaAtual.Coluna)
            {
                if(celulaAtual.CelulaDireita == null )
                {
                    return new Celula(null, null, col, lin, 0);
                }
                if (i == col)
                    return celulaAtual;
                celulaAtual = celulaAtual.CelulaDireita;
            }

            return new Celula(null, null, col, lin, 0);
        }

        public void Inserir(int lin, int col, double val)
        {
            if (lin > 0 && lin <= this.linhas && col <= this.colunas && col > 0 && val != 0)
            {
                Celula novaCelula = Buscar(lin, col);
                if (novaCelula.Valor != 0)
                    novaCelula.Valor = val;
                else
                {
                    novaCelula = new Celula(null, null, col, lin, val);
                    celulaAtual = primeiraCelula;
                    for (int i = celulaAtual.Linha; i < lin; i = celulaAtual.Linha)
                    {
                        CelulaAnterior = celulaAtual;
                        celulaAtual = celulaAtual.CelulaBaixo;

                        if (celulaAtual.Linha == lin)
                        {
                            celulaAtual.Linha = i;

                            for (int a = celulaAtual.Coluna; a < col; a = celulaAtual.Coluna)
                            {
                                CelulaAnterior = celulaAtual;
                                celulaAtual = celulaAtual.CelulaDireita;

                                if(celulaAtual.Coluna == col)
                                {
                                    celulaAtual.Coluna = a;

                                    if(celulaAtual.CelulaDireita == null)
                                    {
                                        celulaAtual.CelulaDireita = novaCelula;
                                        novaCelula.CelulaDireita = null;

                                        if(celulaAtual.CelulaBaixo == null)
                                        {
                                            celulaAtual.CelulaBaixo = novaCelula;
                                            novaCelula.CelulaBaixo = null;
                                        }
                                        else
                                        {
                                            for(int b = 0; b < novaCelula.Linha; b++)
                                            {
                                                Celula aCel = new Celula(null, null, novaCelula.Coluna, 1, 0);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SomarK(int col, int k)
        {
            if (col > 0 && col < colunas && k != 0)
            {
                celulaAtual = primeiraCelula;

                for (int a = celulaAtual.Coluna; a < col; a = celulaAtual.Coluna)
                {
                    celulaAnterior = celulaAtual;
                    celulaAtual = celulaAtual.CelulaDireita;
                }

                celulaAtual = celulaAtual.CelulaBaixo;

                for(int i = 0; i <= linhas; i++)
                {
                    if (Buscar(i, celulaAtual.Coluna).Valor != 0)
                    {
                        if(celulaAtual.Valor + k ==0)
                        {
                            celulaAnterior = celulaAtual;
                            celulaAtual = celulaAtual.CelulaBaixo;

                           // Deletar(celulaAnterior);
                        }
                        else
                        {
                            celulaAtual.Valor = celulaAtual.Valor + k;
                            celulaAnterior = celulaAtual;
                            celulaAtual = celulaAtual.CelulaBaixo;
                        }
                    }
                    else
                    {
                        Inserir(i, celulaAtual.Coluna, k);
                        celulaAnterior = celulaAtual;
                        celulaAtual = Buscar(i, celulaAtual.Coluna);                    }
                }
            }
        }

        public void Exibir(DataGridView onde)
        {
            onde.RowCount = linhas;
            onde.ColumnCount = colunas;

            celulaAtual = primeiraCelula.CelulaBaixo;

            for(int i = 0; i < linhas; i++)
            {
                for(int a = 0; a < colunas; a++)
                {
                    if(celulaAtual.CelulaDireita == null)
                    {
                        for(int b = celulaAtual.Coluna + 1; b < colunas; b++)
                        {
                            onde[b, i].Value = 0;
                        }
                    }
                    else
                    {
                        for(int b = a; b < celulaAtual.Coluna; b++)
                        {

                        }
                        onde[celulaAtual.Coluna, i].Value = celulaAtual.CelulaDireita.Valor;
                    }                
                }
            }
        }
    }
}

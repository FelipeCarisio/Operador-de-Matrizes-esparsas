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
        int linhas = 0, colunas = 0;

        Celula celulaAtual = null, ultimaCelula = null, primeiraCelula = null, celulaAnterior = null;

        public MatrizEsparsa(int col, int lin)
        {
            this.linhas = lin;
            this.colunas = col;

            this.primeiraCelula = new Celula(null, null, 0, 0, 0);
            this.celulaAtual = this.primeiraCelula;

            for(int i = 0; i <= linhas; i++)
            {
                if (i == 0)
                {
                    for (int a = 0; a <= colunas; a++)
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

        private int tamanhoDimen = 5, tamanhoValor = 10;
        public int Linhas { get => linhas; set => linhas = value; }
        public int Colunas { get => colunas; set => colunas = value; }
        public Celula CelulaAtual { get => celulaAtual; set => celulaAtual = value; }
        public Celula UltimaCelula { get => ultimaCelula; set => ultimaCelula = value; }
        public Celula PrimeiraCelula { get => primeiraCelula; set => primeiraCelula = value; }
        public Celula CelulaAnterior { get => celulaAnterior; set => celulaAnterior = value; }

        public Celula Buscar(int lin, int col)
        {
            celulaAtual = PrimeiraCelula;
            for(int i = celulaAtual.Linha; i < lin; i = celulaAtual.Linha)
            {
                celulaAtual = celulaAtual.CelulaBaixo;
            }

            for(int i = celulaAtual.Coluna; i < col; i = celulaAtual.Coluna)
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
                Celula  novaCell = new Celula(null,null,col,lin,val);
                if (Buscar(lin, col).Valor != 0)
                    Buscar(lin, col).Valor = val;
                else
                {
                    CelulaAtual = primeiraCelula;
                    while (CelulaAtual.Linha != lin)
                    {
                        CelulaAtual = CelulaAtual.CelulaBaixo;
                    }
                    while(CelulaAtual != null)
                    {
                        if (CelulaAtual.Coluna < col)
                        {
                            celulaAnterior = CelulaAtual;
                            CelulaAtual = CelulaAtual.CelulaDireita;
                        }
                    }
                    novaCell.CelulaDireita = CelulaAtual;
                    celulaAnterior.CelulaDireita = novaCell;

                    CelulaAtual = primeiraCelula;
                    while (CelulaAtual.Coluna != col)
                    {
                        CelulaAtual = CelulaAtual.CelulaDireita;
                    }
                    while (CelulaAtual != null)
                    {
                        if (CelulaAtual.Linha < lin)
                        {
                            celulaAnterior = CelulaAtual;
                            CelulaAtual = CelulaAtual.CelulaBaixo;
                        }
                    }
                    novaCell.CelulaBaixo = CelulaAtual;
                    celulaAnterior.CelulaBaixo = novaCell;
                }
            }
        }

        public MatrizEsparsa LerMatriz(string caminho)
        {
            StreamReader leitor = new StreamReader(caminho);
            string dados = leitor.ReadLine();
            MatrizEsparsa novaMat = new MatrizEsparsa(int.Parse(dados.Substring(0, tamanhoDimen)), int.Parse(dados.Substring(tamanhoDimen, tamanhoDimen)));
            while(!leitor.EndOfStream)
            {
                dados = leitor.ReadLine();
                novaMat.Inserir(int.Parse(dados.Substring(0, tamanhoDimen))
                    , int.Parse(dados.Substring(tamanhoDimen , tamanhoDimen))
                    , double.Parse(dados.Substring(2 * tamanhoDimen, tamanhoValor)));
            }
            leitor.Close();
            return novaMat;
        }

        public void Deletar(int col,int lin)
        {
            Celula exCell = Buscar(lin, col);
            if(exCell.Valor != 0)
            {
                CelulaAtual = primeiraCelula;
                while (CelulaAtual.Linha != lin)
                {
                    CelulaAtual = CelulaAtual.CelulaBaixo;
                }
                while (CelulaAtual != null)
                {
                    if (CelulaAtual.Coluna < col)
                    {
                        celulaAnterior = CelulaAtual;
                        CelulaAtual = CelulaAtual.CelulaDireita;
                    }
                }
                celulaAnterior.CelulaDireita = exCell.CelulaDireita;

                CelulaAtual = primeiraCelula;
                while (CelulaAtual.Coluna != col)
                {
                    CelulaAtual = CelulaAtual.CelulaDireita;
                }
                while (CelulaAtual != null)
                {
                    if (CelulaAtual.Linha < lin)
                    {
                        celulaAnterior = CelulaAtual;
                        CelulaAtual = CelulaAtual.CelulaBaixo;
                    }
                }
                celulaAnterior.CelulaBaixo = exCell.CelulaBaixo;
            }

        }

        public MatrizEsparsa SomarMatriz(MatrizEsparsa mat)
        {
            if (this.Linhas != mat.Linhas || this.colunas != mat.Colunas)
                return null;
            MatrizEsparsa novaMat = new MatrizEsparsa(mat.Colunas, mat.Linhas);

            novaMat.celulaAtual = primeiraCelula;

            for(int l = 1; l < novaMat.linhas; l++)
            {
                for( int c= 1;c < novaMat.Colunas;c++ )
                {
                    if (this.Buscar(l, c).Valor + mat.Buscar(l, c).Valor != 0)
                    novaMat.Inserir(l, c, this.Buscar(l, c).Valor + mat.Buscar(l, c).Valor);
                }
            }

            return novaMat;
        }

        public MatrizEsparsa MultMatriz(MatrizEsparsa mat)
        {
            MatrizEsparsa novaMat = new MatrizEsparsa(this.Colunas, mat.Linhas);
            int valComum = this.Linhas;
            for(int l = 1; l< novaMat.Linhas; l++)
            {
                for(int c = 1; c< novaMat.Colunas; c++)
                {
                    double aux = 0;
                    for(int n = 1; n < valComum; n++)
                    {
                        aux += this.Buscar(l, n).Valor * mat.Buscar(n, c).Valor;
                    }
                    if (aux != 0)
                        novaMat.Inserir(l, c, aux);
                }
            }
            return novaMat;
        }

        public void SomarK(int col, double k)
        {
            if (col > 0 && col < colunas && k != 0)
            {
                for(int i = 1; i< Linhas; i++)
                {
                    Celula aux = Buscar(i, col);
                    if (aux.Valor != 0)
                    {
                        if (aux.Valor + k != 0)
                            aux.Valor = +k;
                        else
                            Deletar(aux.Coluna,aux.Linha);
                    }
                    else
                        Inserir(i, col, k);
                }
            }
        }

        public void Exibir(DataGridView onde)
        {
            onde.RowCount = linhas;
            onde.ColumnCount = colunas;

            for(int c = 1; c<= this.colunas; c++)
            {
                for(int l = 1;l<=this.Linhas; l++)
                {
                    onde[c - 1, l - 1].Value = Buscar(l, c).Valor;
                }
            }
          
        }
    }
}

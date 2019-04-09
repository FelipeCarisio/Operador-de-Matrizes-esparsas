using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18181_18185_Projeto1ED
{
    public partial class Form1 : Form
    {
        private enum estado {navegando, inserindo, exibindo, excluindo, pesquisando, somandoK, criando};
        private int estadoAtual = (int)estado.navegando;
        private MatrizEsparsa matriz1 = null, matriz2 = null, matrizAtual = null;
        private Button[] botoes;

        public void atualizaBtns()
        {
            if(estadoAtual == (int)estado.navegando)
            {
                if (matriz1 == null)
                {
                    foreach (Button botao in botoes)
                    {
                        if (botao == btnRead || botao == btnCriar)
                        {
                            botao.Enabled = true;
                        }
                        else
                            botao.Enabled = false;
                    }
                }
                else
                {
                    if(matriz2 == null)
                    {
                        foreach(Button botao in botoes)
                        {
                            if (botao == btnConfirmar || botao == btnCancelar || botao == btnMultiplicar || botao == btnSomaMatriz)
                                botao.Enabled = false;
                            else
                                botao.Enabled = true;
                        }
                    }
                    else
                    {
                        foreach (Button botao in botoes)
                        {
                            if (botao == btnCriar || botao == btnRead || botao == btnConfirmar || botao == btnCancelar)
                                botao.Enabled = false;
                            else
                                botao.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                foreach(Button botao in botoes)
                {
                    if (botao == btnConfirmar || botao == btnCancelar)
                    {
                        botao.Enabled = true;
                    }
                    else
                        botao.Enabled = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            botoes = new Button[] {btnAdd, btnAddAll, btnCancelar, btnConfirmar, btnCriar, btnDeleta, btnMultiplicar, btnRead, btnRemover, btnReturn, btnSomaMatriz };
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            estadoAtual = (int)estado.excluindo;
            txtColuna.Enabled = true;
            txtLinha.Enabled = true;
            atualizaBtns();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            txtLinha.Enabled = true;
            txtColuna.Enabled = true;
            estadoAtual = (int)estado.pesquisando;
            atualizaBtns();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            estadoAtual = (int)estado.inserindo;
            txtColuna.Enabled = true;
            txtLinha.Enabled = true;
            txtValor.Enabled = true;
            atualizaBtns();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(ofdLeitura.ShowDialog() == DialogResult.OK)
            {                
                if (matrizAtual == matriz1 && matrizAtual == null)
                {
                    matriz1 = new MatrizEsparsa(1, 1);
                    matriz1 = matriz1.LerMatriz(ofdLeitura.FileName);
                    label3.Visible = true;
                    dgvUm.Visible = true;
                    matriz1.Exibir(dgvUm);
                    matrizAtual = matriz2;
                }
                else
                {
                    matriz2 = new MatrizEsparsa(1, 1);
                    matriz2 = matriz1.LerMatriz(ofdLeitura.FileName);
                    label2.Visible = true;
                    dgvDois.Visible = true;
                    matriz2.Exibir(dgvDois);
                }
            }
            atualizaBtns();
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            if (matrizAtual == matriz2)
            {
                matriz2 = null;
                label2.Visible = false;
                dgvDois.Visible = false;
                matrizAtual = matriz1;
            }
            else
            {
                matriz1 = null;
                label3.Visible = false;
                dgvUm.Visible = false;
                matrizAtual = matriz1;
            }
            atualizaBtns();
        }

        private void btnSomaMatriz_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            DgvResult.Visible = true;
            matriz1.SomarMatriz(matriz2).Exibir(DgvResult);
            estadoAtual = (int)estado.exibindo;
            atualizaBtns();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            DgvResult.Visible = true;
            matriz1.MultMatriz(matriz2).Exibir(DgvResult);
            estadoAtual = (int)estado.exibindo;
            atualizaBtns();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
            txtColuna.Enabled = true;
            estadoAtual = (int)estado.somandoK;
            atualizaBtns();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoAtual = (int)estado.navegando;
            txtValor.Enabled = false;
            txtColuna.Enabled = false;
            txtLinha.Enabled = false;
            txtValor.Text = "";
            txtLinha.Text = "";
            txtColuna.Text = "";
            atualizaBtns();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch(estadoAtual)
            {
                case (int)estado.criando:
                    if ( matriz1 == matrizAtual && matrizAtual == null)
                    {
                        matriz1= new MatrizEsparsa(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text));
                        label3.Visible = true;
                        dgvUm.Visible = true;
                        matriz1.Exibir(dgvUm);
                        matrizAtual = matriz2;
                    }
                    else
                    {
                        matriz2 = new MatrizEsparsa(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text));
                        label2.Visible = true;
                        dgvDois.Visible = true;
                        matriz2.Exibir(dgvDois);
                        matrizAtual = matriz2;
                    }
                    btnCancelar.PerformClick();
                    break;
                case (int)estado.exibindo:
                    label1.Visible = false;
                    DgvResult.Visible = false;
                    DgvResult.RowCount = 0;
                    DgvResult.ColumnCount = 0;
                    estadoAtual = (int)estado.navegando;
                    atualizaBtns();
                    break;
                case (int)estado.excluindo:
                    matrizAtual.Deletar(int.Parse(txtColuna.Text), int.Parse(txtLinha.Text));
                    btnCancelar.PerformClick();
                    if (matrizAtual == matriz2)
                        matrizAtual.Exibir(dgvDois);
                    else
                        matrizAtual.Exibir(dgvUm);
                    break;
                case (int)estado.inserindo:
                    matrizAtual.Inserir(int.Parse(txtLinha.Text), int.Parse(txtColuna.Text), double.Parse(txtValor.Text));
                    btnCancelar.PerformClick();
                    if (matrizAtual == matriz2)
                        matrizAtual.Exibir(dgvDois);
                    else
                        matrizAtual.Exibir(dgvUm);
                    break;
                case (int)estado.somandoK:
                    matrizAtual.SomarK(int.Parse(txtColuna.Text), double.Parse(txtValor.Text));
                    btnCancelar.PerformClick();
                    if (matrizAtual == matriz2)
                        matrizAtual.Exibir(dgvDois);
                    else
                        matrizAtual.Exibir(dgvUm);
                    break;
                case (int)estado.pesquisando:
                    MessageBox.Show("o valor na célula é: " + (matrizAtual.Buscar(int.Parse(txtLinha.Text), int.Parse(txtColuna.Text)).Valor).ToString());
                    btnCancelar.PerformClick();
                    break;
            }
        }

        private void txtColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrizAtual = matriz1;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            txtColuna.Enabled = true;
            txtLinha.Enabled = true;
            estadoAtual = (int)estado.criando;
            atualizaBtns();
        }
    }
}

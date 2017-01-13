using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_pratico;

namespace TrabalhoPraticoForm
{
    public partial class FormAlterarArtigo : Form
    {
        SuperMercado m;
        Artigo a;
        public FormAlterarArtigo(SuperMercado m, Artigo a)
        {
            InitializeComponent();
            this.m = m;
            this.a = a;
            txtBoxCodigoArtigo2.Text = a.Codigocartao;
            txtBoxNomeArtigo2.Text = a.Nome;
            txtBoxPreco2.Text = a.Precounitario.ToString("0.00");
            txtBoxQuantidade2.Text = a.Quantidadestock.ToString("0");

        }

        public float ConfirmaFloat()
        {
            bool n = false;
            string o = "";
            float y;
            o = txtBoxPreco2.Text;
            n = float.TryParse(o, out y);

            if (!n)
            {
                throw new Exception("Insira um valor numérico para o preço");
                
            }
            return y;
        }

        public int ConfirmaInt()
        {
            bool n = false;
            string o = "";
            int y;
            o = txtBoxQuantidade2.Text;
            n = int.TryParse(o, out y);

            if (!n)
            {
                throw new Exception("Insira um valor numérico para o stock");
            }
            return y;
        }

        private void btnAlterarArtigo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende guardar as alterações", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (txtBoxCodigoArtigo2.Text == "")
                    {
                        MessageBox.Show("Preencha o Codigo do Artigo", "Erro");
                        txtBoxCodigoArtigo2.Focus();
                    }
                    else
                    if (txtBoxNomeArtigo2.Text == "")
                    {
                        MessageBox.Show("Preencha o Nome do Artigo", "Erro");
                        txtBoxNomeArtigo2.Focus();
                    }
                    else
                    {
                        a.Codigocartao = txtBoxCodigoArtigo2.Text;
                        a.Precounitario = ConfirmaFloat();
                        a.Quantidadestock = ConfirmaInt();
                        a.Descricao = richtxtDescricao2.Text;
                        a.Nome = txtBoxNomeArtigo2.Text;
                        m.ListaArtigos[txtBoxCodigoArtigo2.Text] = a;
                        MessageBox.Show("Artigo alterado com sucesso!");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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
    public partial class FormAdicionarArtigo : Form
    {
        SuperMercado s;
        public FormAdicionarArtigo(SuperMercado s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void btnAdicionarArtigo_Click(object sender, EventArgs e)
        {
            try
            { 
                if (txtBoxCodigoArtigo.Text == "")
                {
                    MessageBox.Show("Preencha o Codigo do Artigo", "Erro");
                    txtBoxCodigoArtigo.Focus();
                }
                else
                if (txtBoxNomeArtigo.Text == "")
                {
                    MessageBox.Show("Preencha o Codigo do Artigo", "Erro");
                    txtBoxNomeArtigo.Focus();
                }
                else
                {
                    string codigo = txtBoxCodigoArtigo.Text;
                    float preco = ConfirmaFloat();
                    int quantidadestock = ConfirmaInt();
                    string comentario = richtxtDescricao.Text;
                    string nome = txtBoxNomeArtigo.Text;
                    Artigo art = new Artigo(codigo, comentario, preco, quantidadestock,nome);
                    s.AdicionarArtigo(art);
                    MessageBox.Show("Emprestimo criado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float ConfirmaFloat()
        {
            bool n = false;
            string o = "";
            float y;
            o = txtBoxPreco.Text;
            n = float.TryParse(o, out y);
            
            if (!n)
            {
                throw new Exception("Insira um número");
            }
            return y;
        }

        public int ConfirmaInt()
        {
            bool n = false;
            string o = "";
            int y;
            o = txtBoxPreco.Text;
            n = int.TryParse(o, out y);

            if (!n)
            {
                throw new Exception("Insira um número");
            }
            return y;
        }
    }
}

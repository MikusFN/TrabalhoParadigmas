using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPratico;

namespace TrabalhoPraticoForm
{
    public partial class AlterarCartao : Form
    {
        //Mercado e Cartao
        SuperMercado m;
        Cartao c;
        public AlterarCartao(Cartao c, SuperMercado m)
        {
            InitializeComponent();
            this.c = c;
            this.m = m;
            //A pagina vai abrir logo com coisas escritas
            textBoCartao2.Text = c.NumeroCartaoCidadao;
            textBoNome2.Text = c.Nome;
            textBoEmail2.Text = c.Email;
            textBoMorada2.Text = c.Morada;
            textBoNif2.Text = c.NIF;
            textBoTelefone2.Text = c.Telefone;
        }

        //Para alterar
        private void buttoAlterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Confirmar que nenhuma braket esta em branco
                    //C.C
                    if (textBoCartao2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo Cartao de Cidadao");
                        textBoCartao2.Focus();
                    }
                    //NOME
                    else if (textBoNome2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Nome");
                        textBoNome2.Focus();
                    }
                    //NIF
                    else if (textBoNif2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do NIF");
                        textBoNome2.Focus();
                    }
                    //MORADA
                    else if (textBoMorada2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo da Morada");
                        textBoMorada2.Focus();
                    }
                    //TELEFONE
                    else if (textBoTelefone2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Telefone");
                        textBoTelefone2.Focus();
                    }
                    //EMAIL
                    else if (textBoEmail2.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Email");
                        textBoEmail2.Focus();
                    }
                    else
                    {
                        c.Nome = textBoNome2.Text;
                        c.NumeroCartaoCidadao = textBoCartao2.Text;
                        c.NIF = textBoNif2.Text;
                        c.Morada = textBoMorada2.Text;
                        c.Telefone = textBoTelefone2.Text;
                        c.Email = textBoEmail2.Text;
                        MessageBox.Show("Cartao alterado com sucesso!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

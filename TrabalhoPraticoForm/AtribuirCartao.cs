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
    public partial class AtribuirCartao : Form
    {
        Cartao Acartao;
        SuperMercado Mercado;
        public AtribuirCartao(Cartao cartao)
        {
            InitializeComponent();
            this.Acartao = cartao;
            
        }
        private void AtribuirCartao_Load(object sender, EventArgs e)
        {

        }

        private void buttoConcluir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Confirmar que nenhuma braket esta em branco
                    //C.C
                    if (textBoCartao.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo Cartao de Cidadao");
                        textBoCartao.Focus();
                    }
                    //NOME
                    else if (textBoNome.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Nome");
                        textBoNome.Focus();
                    }
                    //NIF
                    else if(textBoNif.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do NIF");
                        textBoNome.Focus();
                    }
                    //MORADA
                    else if (textBoMorada.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo da Morada");
                        textBoMorada.Focus();
                    }
                    //TELEFONE
                    else if (textBoTelefone.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Telefone");
                        textBoTelefone.Focus();
                    }
                    //EMAIL
                    else if (textBoEmail.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Email");
                        textBoEmail.Focus();
                    }
                    //converter o texto introduzido para as variaveis
                    else
                    {
                        string Nome = textBoNome.Text;
                        string Cartao = textBoCartao.Text;
                        string Nif = textBoNif.Text;
                        string Morada = textBoMorada.Text;
                        string Telefone = textBoTelefone.Text;
                        string Email = textBoEmail.Text;

                        Cartao cart = new Cartao(Nome, Cartao, Nif, Morada, Telefone, Email);
                    //Verificar novamente que nao ha erros
                        Mercado.AtribuirCartao(cart);

                        MessageBox.Show("Cartao feito com sucesso");
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

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
    public partial class RegistarCompras : Form
    {
        SuperMercado Mercado;
        Cartao cartao;
        public RegistarCompras(Cartao cartao)
        {
            InitializeComponent();
            this.FormClosing += RegistarComprasForm_FormClosing;
        }
        private void RegistarComprasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Guardar(cartao);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void buttonConcluirRegistar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Confirmar que nenhuma braket esta em branco
                    //CODIGO DO ARTIGO
                    if (textBoxCodigo .Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Codigo do Artigo");
                        textBoxCodigo.Focus();
                    }
                    //QUANTIDADE
                    else if (textBoxQuantidade.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo da Quantidade");
                        textBoxQuantidade .Focus();
                    }
                    //VALOR DE COMPRA
                    else if (textBoxValor.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Preencha o campo do Valor de compra");
                        textBoxValor.Focus();
                    }
                    //converter o texto introduzido para as variaveis
                    else
                    {
                        string Codigo = textBoxCodigo.Text;
                        string Descricao = textBoxDescricao.Text;
                        string Quantidade = textBoxQuantidade.Text;
                        string Valor = textBoxValor.Text;

                        Movimento mov = new Movimento(Codigo, Descricao, Quantidade, Valor);
                        //Verificar novamente que nao ha erros
                        Mercado.AtribuirCompra(mov);

                        MessageBox.Show("Compra registada com sucesso");
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

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
using TrabalhoPratico;

namespace TrabalhoPraticoForm
{
    public partial class RegistarCompras : Form
    {
        SuperMercado Mercado;
        Cartao cartao;
        List<Movimento> movimentostemp = new List<Movimento>();
        public RegistarCompras(Cartao cartao)
        {
            InitializeComponent();
            comboBoxArtigos.Items.AddRange(this.Mercado.ListaArtigos.Values.ToArray());
            this.cartao = cartao;
        }
       
        private void buttonConcluirRegistar_Click(object sender, EventArgs e)
        {
            {
                if (movimentostemp.Count() >= 1)
                {
                    cartao.AdicionarListaCompras(movimentostemp);
                    MessageBox.Show("Foram adicionados com sucesso estas compras");
                    Close();
                }
            }
        }

        private void btAdicionarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Artigo art = (Artigo)comboBoxArtigos.SelectedItem;
                string Codigo = art.Codigocartao;
                string Descricao = textBoxDescricao.Text;
                int Quantidade = (int)numericQuantidade.Value;
                float valor = (float)(Quantidade * art.Precounitario);
                Movimento mov = new Movimento(Codigo, Descricao, Quantidade, valor);
                string nome = art.Nome;
                movimentostemp.Add(mov);
                listbxCompras.Items.Add(nome);
                foreach (Artigo a in Mercado.ListaArtigos.Values)
                {
                    if (a.Codigocartao == Codigo)
                    {
                        a.Quantidadestock -= (int)numericQuantidade.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {
            Artigo art = (Artigo)comboBoxArtigos.SelectedItem;
            numericQuantidade.Maximum = art.Quantidadestock;
        }
    }
}

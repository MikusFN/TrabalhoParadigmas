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
        //Variaveis
        SuperMercado M;
        Cartao cartao;
        float valorescrito;
        List<Movimento> movimentostemp = new List<Movimento>();
        public RegistarCompras(Cartao cartao, SuperMercado Mercado)
        {
            InitializeComponent();
            this.cartao = cartao;
            M = Mercado;
            //Load dos Artigos
            comboBoxArtigos.Items.AddRange(this.M.ListaArtigos.Keys.ToArray());
            
        }
       
        //Concluir o registo
        private void buttonConcluirRegistar_Click(object sender, EventArgs e)
        {
            {
                if (movimentostemp.Count() >= 1)
                {
                    cartao.AdicionarListaCompras(movimentostemp);
                    cartao.Pontos += (int)valorescrito / 50;
                    MessageBox.Show("Foram adicionados com sucesso estas compras");
                    Close();
                }
            }
        }

        //Adicionar combra
        private void btAdicionarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                //Artigo e a quantidade nao podem ser 0
                if (((string)comboBoxArtigos.SelectedItem != "0") && ((int)numericQuantidade.Value != 0))
                {
                    Artigo art = M.ListaArtigos[(string)comboBoxArtigos.SelectedItem];
                    string Codigo = art.Codigocartao;
                    string Descricao = textBoxDescricao.Text;
                    int Quantidade = (int)numericQuantidade.Value;
                    //A quantidade nao pode ser maior que o stock
                    if (Quantidade <= art.Quantidadestock)
                    {
                        float valor = (float)(Quantidade * art.Precounitario);
                        Movimento mov = new Movimento(Codigo, Descricao, Quantidade, valor);
                        string nome = art.Nome;
                        //Tira o stock AUTOMATICAMENTE
                        foreach (Artigo a in M.ListaArtigos.Values)
                        {
                            if (a.Codigocartao == Codigo)
                            {
                                if (a.Quantidadestock > 0)
                                    a.Quantidadestock -= (int)numericQuantidade.Value;
                            }
                        }
                        movimentostemp.Add(mov);
                        //valorescrito no ecra e atualizado para o utilizador saber quanto esta a desperdiçar
                        valorescrito += valor;
                        listbxCompras.Items.Add(nome);
                    }
                    else
                    {
                        MessageBox.Show("Stock Insuficiente");
                        numericQuantidade.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Veja se o artigo tem stock suficiente ou se esqueceu-se de selecionar o artigo.");
                    comboBoxArtigos.Focus();
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxValor.Clear();
            textBoxValor.Text += valorescrito.ToString("0.00");
        }

        //O utilizador so pdoe escolher entre 0 e o numero maximo do stock do artigo
        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {
            string codigo = (string)comboBoxArtigos.SelectedItem;

            Artigo art = M.ListaArtigos[codigo];

            numericQuantidade.Maximum = art.Quantidadestock;
        }

        private void buttonRecuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

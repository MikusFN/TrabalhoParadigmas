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
    public partial class ConsultarSaldo : Form
    {
        string codigo;
        Movimento mov;
        SuperMercado mercado;

        public ConsultarSaldo(string codigo,SuperMercado mercado)
        {
            InitializeComponent();
            CriaTabela();
            this.codigo = codigo;
            this.mercado = mercado;
        }
        //Recuar 
        private void buttonRecuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Tabela Consultar Saldo
        private void CriaTabela()
        {
            dataGridViewSaldo.Columns.Clear();
            dataGridViewSaldo.Rows.Clear();

            // cria as colunas relevantes para os livros
            dataGridViewSaldo.Columns.Add("Quantia Gasta", "Quantia Gasta");
            dataGridViewSaldo.Columns.Add("Pontos", "Pontos");
            float ValorSaldo = 0;
            foreach (Cartao card in mercado.ListaClientes)
            {
                if (card.NumeroCartaoCidadao == codigo)
                {
                    for (int i = 0; i < card.Movimentos.Count(); i++)
                    {
                        foreach (Movimento mov in card.Movimentos)
                        {
                            ValorSaldo += mov.ValordaCompra;
                        }
                    }
                    int index = dataGridViewSaldo.Rows.Add();
                    dataGridViewSaldo.Rows[index].Cells[0].Value = ValorSaldo;
                    dataGridViewSaldo.Rows[index].Cells[0].Value = (int)ValorSaldo/50;
                }
            }
            
        }
    }
}

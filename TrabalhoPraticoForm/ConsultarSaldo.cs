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
        Cartao cartao;
        Movimento mov;
        SuperMercado mercado;

        public ConsultarSaldo(Cartao cartao)
        {
            InitializeComponent();
            CriaTabela();
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
            dataGridViewSaldo.Columns.Add("Saldo", "Saldo");
            dataGridViewSaldo.Columns.Add("Pontos", "Pontos");

            for(int i = 0; i < cartao.Movimentos.Count(); i++)
            {
                foreach (Movimento mov in cartao.Movimentos)
                {
                    float ValorSaldo = +int.Parse(mov.ValordaCompra);
                }
            }
            int index = dataGridViewSaldo.Rows.Add();
            dataGridViewSaldo.Rows[index].Cells[0].Value = ValorSaldo;
            /////////////BUG////////////
        }
    }
}

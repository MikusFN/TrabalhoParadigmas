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
    public partial class ConsultarCompras : Form
    {
        Cartao cartao;
        Movimento mov;
        public ConsultarCompras(Movimento movimento)
        {
            InitializeComponent();
            //Criar a tabela mal se entre nesta janela
            CriaTabela();
            this.FormClosing += ConsultarCompras_FormClosing;
        }
        //Sair do programa
        private void ConsultarCompras_FormClosing(object sender, FormClosingEventArgs e)
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
        //Criar Tabela para Consulta
        private void CriaTabela()
        {
            
            dataGridRegistos.Columns.Clear();
            dataGridRegistos.Rows.Clear();

            // cria as colunas relevantes para os livros
            dataGridRegistos.Columns.Add("Codigo Artigo", "Codigo Artigo");
            dataGridRegistos.Columns.Add("Quantidade", "Quantidade");
            dataGridRegistos.Columns.Add("Valor", "Valor");
            dataGridRegistos.Columns.Add("Descricao", "Descricao");

            // adiciona cada registo existente em movimentos à gridview
            foreach (Movimento mov in cartao.Movimentos)
            {
                int index = dataGridRegistos.Rows.Add();
                dataGridRegistos.Rows[index].Cells[0].Value = mov.CodigodeArtigo;
                dataGridRegistos.Rows[index].Cells[1].Value = mov.Quantidade;
                dataGridRegistos.Rows[index].Cells[2].Value = mov.ValordaCompra;
                dataGridRegistos.Rows[index].Cells[3].Value = mov.Descricao;
            }
        }
        //Butao Recuar
        private void buttonRecuar_Click(object sender, EventArgs e)
        {
            //Recuar para GerirPontos
            this.Close();
        }
    }
}

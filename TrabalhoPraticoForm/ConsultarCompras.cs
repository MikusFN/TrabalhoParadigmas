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
        SuperMercado m;
        string codigo;
        public ConsultarCompras(string codigo,SuperMercado m)
        {
            InitializeComponent();
            //Criar a tabela mal se entre nesta janela
            this.m = m;
            this.codigo = codigo;
            CriaTabela();

        }
        
        //Criar Tabela para Consulta
        private void CriaTabela()
        {
            
            dataGridRegistos.Columns.Clear();
            dataGridRegistos.Rows.Clear();

            // cria as colunas relevantes para os livros
            dataGridRegistos.Columns.Add("Codigo Artigo", "Codigo Artigo");
            dataGridRegistos.Columns.Add("Quantidade da Compra", "Quantidade da Compra");
            dataGridRegistos.Columns.Add("Valor da Compra", "Valor da Compra");
            dataGridRegistos.Columns.Add("Descricao", "Descricao");

            // adiciona cada registo existente em movimentos à gridview
            foreach (Cartao card in m.ListaClientes)
            {
                if (card.NumeroCartaoCidadao == codigo)
                {
                    foreach (Movimento mov in card.Movimentos)
                    {
                        int index = dataGridRegistos.Rows.Add();
                        dataGridRegistos.Rows[index].Cells[0].Value = mov.CodigodeArtigo;
                        dataGridRegistos.Rows[index].Cells[1].Value = mov.Quantidade;
                        dataGridRegistos.Rows[index].Cells[2].Value = mov.ValordaCompra;
                        dataGridRegistos.Rows[index].Cells[3].Value = mov.Descricao;
                    }
                }
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

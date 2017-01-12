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
    public partial class GerirPontos : Form
    {
        SuperMercado Mercado;
        public GerirPontos(SuperMercado Mercado)
        {
            InitializeComponent();
            this.FormClosing += GerirPontos_FormClosing;
            this.Mercado = Mercado;
            CriaTabela();
        }

        private void CriaTabela()
        {
            dtGridGerirCartoes.Columns.Clear();
            dtGridGerirCartoes.Rows.Clear();
            dtGridGerirCartoes.Columns.Add("Nome do Cliente", "Nome do Cliente");
            dtGridGerirCartoes.Columns.Add("Cartão de Cidadão", "Cartão de Cidadão");
            dtGridGerirCartoes.Columns.Add("Telefone", "Telefone");
            dtGridGerirCartoes.Columns.Add("Pontos", "Pontos");
            foreach (Cartao cart in Mercado.ListaClientes)
            {
                int index = dtGridGerirCartoes.Rows.Add();
                dtGridGerirCartoes.Rows[index].Cells[0].Value = cart.Nome;
                dtGridGerirCartoes.Rows[index].Cells[1].Value = cart.NumeroCartaoCidadao;
                dtGridGerirCartoes.Rows[index].Cells[2].Value = cart.Telefone;
                dtGridGerirCartoes.Rows[index].Cells[3].Value = cart.Pontos;

            }
        }
        //Atribuir Cartão
        private void button1_Click(object sender, EventArgs e)
        {
            AtribuirCartao f = new AtribuirCartao(Mercado);
            f.ShowDialog();
        }
        //RegistarCompras
        private void buttonRegistarCompras_Click(object sender, EventArgs e)
        {
            if (dtGridGerirCartoes.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection selecionados = dtGridGerirCartoes.SelectedRows;
                foreach (DataGridViewRow r in selecionados)
                {
                    string codigo = r.Cells[1].Value.ToString();
                    foreach (Cartao c in Mercado.ListaClientes)
                    {
                        if (c.NumeroCartaoCidadao == codigo)
                        {
                            RegistarCompras f = new RegistarCompras(c);
                            f.ShowDialog();
                        }
                    }
                }
                CriaTabela();
            }
        }
        //Fechar Programa
        private void GerirPontos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //Guardar(cartao);
            }
            else
            {
                e.Cancel = true;
            }
        }

        
        //Consultar Compras
        private void buttonConsultarCompras_Click(object sender, EventArgs e)
        {
            if (dtGridGerirCartoes.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection selecionados = dtGridGerirCartoes.SelectedRows;
                foreach (DataGridViewRow r in selecionados)
                {
                string codigo = r.Cells[1].Value.ToString();
                ConsultarCompras f = new ConsultarCompras(codigo,Mercado);
                f.ShowDialog();
                }
                CriaTabela();
            }
            
        }
        //Recuar para Menu Anterior
        private void buttonRecuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Consultar Saldo
        private void buttonConsultarSaldo_Click(object sender, EventArgs e)
        {
            if (dtGridGerirCartoes.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection selecionados = dtGridGerirCartoes.SelectedRows;
                foreach (DataGridViewRow r in selecionados)
                {
                    string codigo = r.Cells[1].Value.ToString();
                    ConsultarSaldo d = new ConsultarSaldo(codigo, Mercado);
                    d.ShowDialog();
                }
                CriaTabela();
            }
        }
    }
}

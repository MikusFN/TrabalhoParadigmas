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

namespace TrabalhoPraticoForm
{
    public partial class Actualizar_Artigo : Form
    {
        //Declarar Mercado
        SuperMercado m;
        public Actualizar_Artigo(SuperMercado m)
        {
            InitializeComponent();
            this.m = m;
            CriaTabela();
        }
        //Criar Grid
        private void CriaTabela()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Código de Artigo", "Código de Artigo");
            dataGridView1.Columns.Add("Preço", "Preço");
            dataGridView1.Columns.Add("Quantidade em Stock", "Quantidade em Stock");

            foreach (Artigo art in m.ListaArtigos.Values)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = art.Codigocartao;
                dataGridView1.Rows[index].Cells[1].Value = art.Precounitario;
                dataGridView1.Rows[index].Cells[2].Value = art.Quantidadestock;

            }

        }

        //Codigo Useless
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Aumentar stock
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Tem a certeza que pretende alterar o artigo selecionado?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        {
                            DataGridViewSelectedRowCollection selecionados = dataGridView1.SelectedRows;
                            foreach (DataGridViewRow r in selecionados)
                            {
                                string codigo = r.Cells[0].Value.ToString();
                                Artigo a = m.ListaArtigos[codigo];
                                a.Quantidadestock += ConfirmaInt();
                                MessageBox.Show("O stock foi atualizado com sucesso!");
                                txtAtualizar.Clear();

                            }
                            CriaTabela();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAtualizar.Focus();
                }
            }
        }
        //Useless
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Confirmar que o usuario pos um inteiro
        public int ConfirmaInt()
        {
            bool n = false;
            string o = "";
            int y;
            o = txtAtualizar.Text;
            n = int.TryParse(o, out y);

            if (!n)
            {
                throw new Exception("Insira um valor numérico para o stock");
            }
            return y;
        }

        //Retirar stock
        private void btRetirar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Tem a certeza que pretende alterar o artigo selecionado?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        {
                            DataGridViewSelectedRowCollection selecionados = dataGridView1.SelectedRows;
                            foreach (DataGridViewRow r in selecionados)
                            {
                                string codigo = r.Cells[0].Value.ToString();
                                Artigo a = m.ListaArtigos[codigo];
                                if ((a.Quantidadestock >= ConfirmaInt()))
                                {
                                    a.Quantidadestock -= ConfirmaInt();
                                    MessageBox.Show("O stock foi atualizado com sucesso!");
                                    txtAtualizar.Clear();

                                }
                                else //Caso Nao tenha stock suficiente
                                {
                                    MessageBox.Show("Stock Insuficiente!");
                                    txtAtualizar.Focus();
                                }
                            }
                            CriaTabela();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAtualizar.Focus();
                }
            }
        }
        //Fecha janela
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

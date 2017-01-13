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
    public partial class GerirArtigos : Form
    {
        SuperMercado m;
        public GerirArtigos(SuperMercado m)
        {
            InitializeComponent();
            this.m = m;
            CriaTabela();
            
            
        }

        private void CriaTabela()
        {
            dtGridArtigos.Columns.Clear();
            dtGridArtigos.Rows.Clear();
            dtGridArtigos.Columns.Add("Código de Artigo", "Código de Artigo");
            dtGridArtigos.Columns.Add("Preço", "Preço");
            dtGridArtigos.Columns.Add("Quantidade em Stock", "Quantidade em Stock");

            foreach (Artigo art in m.ListaArtigos.Values)
            {
                int index = dtGridArtigos.Rows.Add();
                dtGridArtigos.Rows[index].Cells[0].Value = art.Codigocartao;
                dtGridArtigos.Rows[index].Cells[1].Value = art.Precounitario;
                dtGridArtigos.Rows[index].Cells[2].Value = art.Quantidadestock;

            }

        }


        private void btRemoverArt_Click(object sender, EventArgs e)
        {
            if (dtGridArtigos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem a certeza que pretende remover o artigo selecionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    {
                        DataGridViewSelectedRowCollection selecionados = dtGridArtigos.SelectedRows;
                        foreach (DataGridViewRow r in selecionados)
                        {
                            string codigo = r.Cells[0].Value.ToString();
                            m.RemoverArtigo(codigo);

                        }
                        CriaTabela();
                    }
                }
            }
        }

        private void btAdicionarArt_Click(object sender, EventArgs e)
        {
            FormAdicionarArtigo f = new FormAdicionarArtigo(m);
            f.ShowDialog();
            CriaTabela();
        }

        private void btAlterarArtigo_Click(object sender, EventArgs e)
        {
            if (dtGridArtigos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem a certeza que pretende alterar o artigo selecionado?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    {
                        DataGridViewSelectedRowCollection selecionados = dtGridArtigos.SelectedRows;
                        foreach (DataGridViewRow r in selecionados)
                        {
                            string codigo = r.Cells[0].Value.ToString();
                            Artigo a = m.ListaArtigos[codigo];
                            FormAlterarArtigo f = new FormAlterarArtigo(m, a);
                            f.ShowDialog();

                        }
                        CriaTabela();
                    }
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (dtGridArtigos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Tem a certeza que pretende alterar o artigo selecionado?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        {
                            DataGridViewSelectedRowCollection selecionados = dtGridArtigos.SelectedRows;
                            foreach (DataGridViewRow r in selecionados)
                            {
                                string codigo = r.Cells[0].Value.ToString();
                                Artigo a = m.ListaArtigos[codigo];
                                FormAlterarArtigo f = new FormAlterarArtigo(m, a);
                                f.ShowDialog();

                            }
                            CriaTabela();
                        }
                    }
                }


            }
        }
    }
}

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
    public partial class GerirPontos : Form
    {
        SuperMercado Mercado;
        Cartao cartao;
        Movimento mov;
        public GerirPontos(Cartao cartao)
        {
            InitializeComponent();
            this.FormClosing += GerirPontos_FormClosing;
            
        }
        //Atribuir Cartão
        private void button1_Click(object sender, EventArgs e)
        {
            AtribuirCartao f = new AtribuirCartao(cartao);
            f.ShowDialog();
        }
        //RegistarCompras
        private void buttonRegistarCompras_Click(object sender, EventArgs e)
        {
            RegistarCompras f = new RegistarCompras(cartao);
            f.ShowDialog();
        }
        //Fechar Programa
        private void GerirPontos_FormClosing(object sender, FormClosingEventArgs e)
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
        //Consultar Compras
        private void buttonConsultarCompras_Click(object sender, EventArgs e)
        {
            ConsultarCompras f = new ConsultarCompras(mov);
            f.ShowDialog();
        }
        //Recuar para Menu Anterior
        private void buttonRecuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Consultar Saldo
        private void buttonConsultarSaldo_Click(object sender, EventArgs e)
        {
            ConsultarSaldo f = new ConsultarSaldo(mov);
            f.ShowDialog();
        }
    }
}

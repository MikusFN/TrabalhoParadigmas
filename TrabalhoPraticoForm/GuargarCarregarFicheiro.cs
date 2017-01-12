using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TrabalhoPraticoForm
{
    public partial class SuperDume : Form
    {
        SuperMercado sm;
        public SuperDume()
        {
            InitializeComponent();
            this.FormClosing += SuperDume_FormClosing;
            sm = sm.CarregarDados();
        }

        private void SuperDume_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                GuardarDados();

            }
            else
            {
                e.Cancel = true;
            }

        }

        private void CarregarFicheiro_Click(object sender, EventArgs e)
        {
            sm.GuardarDados();
        }

        private void GuardarFicheiro_Click(object sender, EventArgs e)
        {
            sm.CarregarDados();
        }
        public void GuardarDados()
        {
            try
            {
                SuperMercado sp = new SuperMercado("SuperDume");
            Stream s = File.Open("SuperDume.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, sp);
            s.Close();
            }

            catch (FileNotFoundException fe)
            {
                MessageBox.Show("Ficheiro inexistente!");
            }
            catch (DirectoryNotFoundException de)
            {
                MessageBox.Show("Directoria invalida!");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO!");
            }
        }
        public SuperMercado CarregarDados()
        {
            SuperMercado sp = new SuperMercado("SuperDume");
           

                if (File.Exists("SuperDume.bin"))
                {
                    Stream s = File.Open("SuperDume.bin", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    sp = (SuperMercado)bf.Deserialize(s);
                    s.Close();

                }           
            return sp;
        }
    }
}


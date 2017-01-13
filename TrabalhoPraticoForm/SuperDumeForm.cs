﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TrabalhoPraticoForm
{
    public partial class SuperDume : Form
    {
        SuperMercado sm;
        public SuperDume()
        {
            InitializeComponent();
            this.FormClosing += SuperDume_FormClosing;
            sm = CarregaMercado();
        }

        public SuperMercado CarregaMercado()
        {
            SuperMercado sm = new SuperMercado("M");

            if (File.Exists("supermercado.bin"))
            {
                Stream s = File.Open("supermercado.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                sm = (SuperMercado)bf.Deserialize(s);
                s.Close();
            }
            return sm;
        }

        public static void Guardar(SuperMercado m)
        {
            try
            {
                Stream s = File.Open("supermercado.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, m);
                s.Close();
            }
            catch (FileNotFoundException f)
            {
                throw new Exception("Ficheiro inexistente");
            }
            catch (DirectoryNotFoundException d)
            {
                throw new Exception("Directoria invalida");
            }
            catch (Exception ex)
            {
                throw new Exception("Excepcao generica");
            }
        }

        private void SuperDume_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Guardar(sm);

            }
            else
            {
                e.Cancel = true;
            }

        }

        private void CarregarFicheiro_Click(object sender, EventArgs e)
        {
            try
            {
                sm=CarregaMercado();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void GuardarFicheiro_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar(sm);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGerirArtigos_Click(object sender, EventArgs e)
        {
            GerirArtigos f = new GerirArtigos(sm);
            f.ShowDialog();
            
        }

        private void btGerirCartoes_Click(object sender, EventArgs e)
        {
            GerirPontos f = new GerirPontos(sm);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


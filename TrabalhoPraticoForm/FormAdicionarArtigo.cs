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
    public partial class FormAdicionarArtigo : Form
    {
        //SuperMercado
        SuperMercado m;
        public FormAdicionarArtigo(SuperMercado s)
        {
            InitializeComponent();
            this.m = s;
        }

        //Adicionar Artigo
        private void btnAdicionarArtigo_Click(object sender, EventArgs e)
        {
            try
            { 
                //Campos que nao podem estar vazios
                if (txtBoxCodigoArtigo.Text == "")
                {
                    MessageBox.Show("Preencha o Codigo do Artigo", "Erro");
                    txtBoxCodigoArtigo.Focus();
                }
                else
                if (txtBoxNomeArtigo.Text == "")
                {
                    MessageBox.Show("Preencha o Nome do Artigo", "Erro");
                    txtBoxNomeArtigo.Focus();
                }
                else
                {
                    //Criar um artigo novo e adiciona-lo a lista
                    string codigo = txtBoxCodigoArtigo.Text;
                    float preco = ConfirmaFloat();
                    int quantidadestock = ConfirmaInt();
                    string comentario = richtxtDescricao.Text;
                    string nome = txtBoxNomeArtigo.Text;
                    Artigo art = new Artigo(codigo, comentario, preco, quantidadestock,nome);
                    m.AdicionarArtigo(art);
                    MessageBox.Show("Artigo criado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Confirmar que o usuario poe um float
        public float ConfirmaFloat()
        {
            bool n = false;
            string o = "";
            float y;
            o = txtBoxPreco.Text;
            n = float.TryParse(o, out y);
            
            if (!n)
            {
                throw new Exception("Insira um valor numérico para o preço");
            }
            return y;
        }
        //Confirmar que o usuario poe um inteiro
        public int ConfirmaInt()
        {
            bool n = false;
            string o = "";
            int y;
            o = txtBoxQuantidade.Text;
            n = int.TryParse(o, out y);

            if (!n)
            {
                throw new Exception("Insira um valor numérico para o stock");
            }
            return y;
        }
    }
}

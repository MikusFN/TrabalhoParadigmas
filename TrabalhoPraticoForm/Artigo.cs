using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_pratico
{
    //Pode ser transformada em binario
    [Serializable]
    public class Artigo
    {
        //Atributos
        private string codigocartao;
        public string Codigocartao
        {
            get { return codigocartao; }
            set { codigocartao = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private float precounitario;
        public float Precounitario
        {
            get { return precounitario; }
            set { precounitario = value; }
        }

        private int quantidadestock;
        public int Quantidadestock
        {
            get { return quantidadestock; }
            set { quantidadestock = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Construtor
        public Artigo(string codigo, string descricao, float precounitario, int quantidadestock, string nome)
        {
            this.codigocartao = codigo;
            this.descricao = descricao;
            this.precounitario = precounitario;
            this.quantidadestock = quantidadestock;
            this.nome = nome;
        }
    }
}


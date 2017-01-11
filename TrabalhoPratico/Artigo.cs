using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_pratico
{
    public class Artigo
    {
        private string codigoartigo;
        public string Codigocartao
        {
            get { return codigoartigo; }
            set { codigoartigo = value; }
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

        public Artigo(string codigo, string descricao, float precounitario, int quantidadestock)
        {
            this.codigoartigo = codigo;
            this.Descricao = descricao;
            this.Precounitario = precounitario;
            this.Quantidadestock = quantidadestock;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    //Cartao
    [Serializable]
    public class Cartao
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string numeroCartaoCidadao;

        public string NumeroCartaoCidadao
        {
            get { return numeroCartaoCidadao; }
            set { numeroCartaoCidadao = value; }
        }

        private string nif;

        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        private string morada;

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int pontos;

        public int Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        private List<Movimento> movimentos;

        public List<Movimento> Movimentos
        {
            get { return movimentos; }
            set { movimentos = value; }
        }
        public Cartao(string nome, string cartaocidadao, string nif, string morada, string telefone, string email)
        {
            this.nome = nome;
            this.numeroCartaoCidadao = cartaocidadao;
            this.nif = nif;
            this.morada = morada;
            this.telefone = telefone;
            this.email = email;
            this.pontos = 0;
            this.movimentos = new List<Movimento>();
        }

        public void AdicionarListaCompras(List<Movimento> mov)
        {
            foreach (Movimento m in mov)
            {
                movimentos.Add(m);
            }
        }

    }

    //Movimentos
    [Serializable]
    public class Movimento
    {
        private string codigodeArtigo;

        public string CodigodeArtigo
        {
            get { return codigodeArtigo; }
            set { codigodeArtigo = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private float valordaCompra;

        public float ValordaCompra
        {
            get { return valordaCompra; }
            set { valordaCompra = value; }
        }
        public Movimento(string codigodeArtigo, string descricao, int quantidade, float valordacompra)
        {
            this.codigodeArtigo = codigodeArtigo;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.valordaCompra = valordacompra;
        }
    }
}

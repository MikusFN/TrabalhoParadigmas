using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_pratico;
using TrabalhoPratico;

namespace TrabalhoPraticoForm
{
    class SuperMercado
    {
        private string nome;
        private Dictionary<string, Artigo> listaartigos;
        private List<Cartao> listaclientes;
        public string Nome { get; set; }
        public  Dictionary<string, Artigo> ListaArtigos { get; set; }
        public List<Cartao> ListaClientes { get; set; }

        public SuperMercado(string nome)
        {
            this.nome = nome;
            this.listaartigos = new Dictionary<string, Artigo>();
            this.listaclientes = new List<Cartao>();
        }



    }
}

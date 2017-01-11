using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_pratico;
using TrabalhoPratico;
using System.Runtime.Serialization.Formatters.Binary;


namespace TrabalhoPraticoForm
{
    [Serializable]
    class SuperMercado
    {
       
        private string nome;
        private Dictionary<string, Artigo> listaartigos;
        private List<Cartao> listaclientes;
        public string Nome { get; set; }
        public Dictionary<string, Artigo> ListaArtigos { get; set; }
        public List<Cartao> ListaClientes { get; set; }

        public SuperMercado(string nome)
        {
            this.nome = nome;
            this.listaartigos = new Dictionary<string, Artigo>();
            this.listaclientes = new List<Cartao>();
        }
        public void GuardarDados()
        {
            SuperMercado sp = new SuperMercado("SuperDume");
            Stream s = File.Open("SuperDume.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, sp);
            s.Close();
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
//public void GuardarDados()//Para guardar ficheiros em exel.
//{     streamWriter sw = new streamWriter("SuperDume.csv");
//    foreach (Artigo art in ListaArtigos.Values)
//    {
//        sw.Write(art.Codigocartao + "," + art.Descricao + "," + art.Precounitario + "," + art.Quantidadestock + ",");
//        sw.WriteLine();

//    }
//    foreach (Cartao card in ListaClientes)
//    {
//        sw.Write(card.Nome + "," + card.NumeroCartaoCidadao + "," + card.NIF + "," + card.Morada + "," + card.Email + "," + card.Telefone + "," + card.Pontos);
//        sw.WriteLine();
//    }
//    sw.Close();
//}



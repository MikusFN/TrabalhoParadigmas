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
        SuperMercado sm;
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
            try
            {

                if (File.Exists("SuperDume.bin"))
                {
                    Stream s = File.Open("SuperDume.bin", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    sp = (SuperMercado)bf.Deserialize(s);
                    s.Close();

                }

            }

            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Ficheiro inexistente!");
            }
            catch (DirectoryNotFoundException de)
            {
                Console.WriteLine("Directoria invalida!");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO!");
            }
            return sp;
        }
        //AtribuirCartao
        public void AtribuirCartao(Cartao cart)
        {
            if (cartao.ContainsKey(cart.NumeroCartaoCidadao))
            {
                throw new Exception("Verifique o numero do cartao de cidadao introduzido");
            }
            else if (cartao.ContainsKey(cart.NIF))
            {
                throw new Exception("Verifique o nif introduzido");
            }
            else if (cartao.ContainsKey(cart.Telefone))
            {
                throw new Exception("Verifique o numero de telefone introduzido");
            }
            else if (listaartigos.ContainsKey(cart.Email))
            {
                throw new Exception("Verifique o Email Introduzido");
            }
            else
            {
                this.cartao.Add(cart.Nome, cart);
                this.cartao.Add(cart.NumeroCartaoCidadao, cart);
                this.cartao.Add(cart.NIF, cart);
                this.cartao.Add(cart.Morada, cart);
                this.cartao.Add(cart.Telefone, cart);
                this.cartao.Add(cart.Email, cart);
            }
        }
        //AtribuirCompra
        public void AtribuirCompra(Movimento mov)
        {
            this.movimentos.Add(mov.CodigodeArtigo, mov);
            this.movimentos.Add(mov.Descricao, mov);
            this.movimentos.Add(mov.Quantidade, mov);
            this.movimentos.Add(mov.ValordaCompra, mov);
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



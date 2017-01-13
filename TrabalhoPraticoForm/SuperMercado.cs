using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_pratico;
using TrabalhoPratico;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;


namespace TrabalhoPraticoForm
{
    [Serializable]
    public class SuperMercado
    {
        private Dictionary<string,Artigo> listaartigos;

        public Dictionary<string,Artigo> ListaArtigos
        {
            get { return listaartigos; }
            set { listaartigos = value; }
        }

        private List<Cartao> listaclientes;

        public List<Cartao> ListaClientes
        {
            get { return listaclientes; }
            set { listaclientes = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public DateTime Today { get; }


        public SuperMercado(string nome)
        {
            this.nome = nome;
            this.listaartigos = new Dictionary<string, Artigo>();
            this.listaclientes = new List<Cartao>();
        }
       
        public void AdicionarArtigo(Artigo a)
        {
            if (listaartigos.ContainsValue(a))
            {
                throw new Exception("Já existe esse artigo");
            }
            listaartigos.Add(a.Codigocartao, a);
        }

        public void RemoverArtigo(string codigo)
        {
            if (ListaArtigos.ContainsKey(codigo))
            {
                ListaArtigos.Remove(codigo);
            }
        }
        
       
        //AtribuirCartao
        public void AtribuirCartao(Cartao cart)
        {
            foreach (Cartao c in listaclientes)
            {
                if (c.NumeroCartaoCidadao == cart.NumeroCartaoCidadao)
                {
                    throw new Exception("Um cliente já se registou com este Cartão de Cidadão. Tente outro por favor.");
                }
                else if (c.NIF == cart.NIF)
                {
                    throw new Exception("Um cliente já se registou com este NIF. Tente outro por favor.");
                }
                else if (c.Telefone == cart.Telefone)
                {
                    throw new Exception("Um cliente já se registou com este Telefone. Tente outro por favor.");
                }
                else if (c.Email == cart.Email)
                {
                    throw new Exception("Um cliente já se registou com este email. Tente outro por favor.");
                }
             }
            listaclientes.Add(cart);
        }
        ////AtribuirCompra
        //public static void GuardarDados(SuperMercado sp)
        //{

        //    Stream s = File.Open("SuperDume.bin", FileMode.Create);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(s, sp);
        //    s.Close();
        //    SuperMercado sd = new SuperMercado("SuperDume");
        //    StreamWriter sw = new StreamWriter("SuperDume.csv");
        //    foreach (Artigo art in sd.ListaArtigos.Values)
        //    {
        //        sw.Write(art.Codigocartao + "," + art.Descricao + "," + art.Precounitario + "," + art.Quantidadestock + ",");


        //    }
        //    sw.WriteLine();
        //    foreach (Cartao card in sd.ListaClientes)
        //    {
        //        sw.Write(card.Nome + "," + card.NumeroCartaoCidadao + "," + card.NIF + "," + card.Morada + "," + card.Email + "," + card.Telefone + "," + card.Pontos);

        //    }
        //    sw.WriteLine();
        //    sw.Close();
        //}
        //public SuperMercado CarregarDados()
        //{
        //    SuperMercado sp = new SuperMercado("SuperDume");
        //    try
        //    {

        //        if (File.Exists("SuperDume.bin"))
        //        {
        //            Stream s = File.Open("SuperDume.bin", FileMode.Open);
        //            BinaryFormatter bf = new BinaryFormatter();
        //            sp = (SuperMercado)bf.Deserialize(s);
        //            s.Close();

        //        }

        //    }

        //    catch (FileNotFoundException fe)
        //    {
        //        Console.WriteLine("Ficheiro inexistente!");
        //    }
        //    catch (DirectoryNotFoundException de)
        //    {
        //        Console.WriteLine("Directoria invalida!");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("ERRO!");
        //    }
        //    return sp;
        //}
        //public void Promocoes(DateTime Today)
        //{

        //    DateTime thisDay = DateTime.Today;
        //    Console.WriteLine(thisDay.ToString("d"));
        //    long t = thisDay.Ticks;
        //    DateTime dateValue = new DateTime(t);
        //    Console.WriteLine(dateValue.ToString("dddd", new CultureInfo("PT-PT")));


        //}

    }
}

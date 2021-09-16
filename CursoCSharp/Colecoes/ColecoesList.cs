using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public int Quantidade;
        public string Nome;
        public double Preco;

        public Produto(int quantidade, string nome, double preco)
        {
            Quantidade = quantidade;
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {

        }

        public override bool Equals(object obj)
        {
            Produto outro = (Produto)obj;
            bool MesmoNome = Nome == outro.Nome;
            bool MesmoPreco = this.Preco == outro.Preco;
            return MesmoNome == MesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecoesList
    {
        public static void Executar()
        {
            List<Produto> carrinho = new List<Produto>();
            
            Console.WriteLine("Quantos produtos para adicionar?");
            int adicionar = int.Parse(Console.ReadLine());
            for (int i = 0; i < adicionar; i++)
            {
                Console.WriteLine("Insira a quantidade, nome e preço do produto.");
                carrinho.Add(new Produto(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine())));
            }

            foreach (Produto item in carrinho)
            {
                Console.WriteLine("{0}: {1} - {2} x {3}", carrinho.IndexOf(item) + 1, item.Nome, item.Preco, item.Quantidade);
            }

            Console.WriteLine("{0} => tamanho do carrinho", carrinho.Count);

            List<Produto> teste = new List<Produto>(){
                new Produto(10, "oi", 10),
                new Produto(10, "afda", 110),
                new Produto(10, "ofdafai", 120),
            };

            // Adicionando um intervalo
            carrinho.AddRange(teste);
            Console.WriteLine("{0} => tamanho do carrinho", carrinho.Count);


        }
    }
}

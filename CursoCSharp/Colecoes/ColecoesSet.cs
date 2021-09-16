using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            HashSet<Produto> carrinho = new HashSet<Produto>();
            
            Console.WriteLine("Quantos produtos para adicionar?");
            int adicionar = int.Parse(Console.ReadLine());
            for (int i = 0; i < adicionar; i++)
            {
                Console.WriteLine("Insira a quantidade, nome e preço do produto.");
                carrinho.Add(new Produto(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine())));
            }

            //Sem estrutura para índice e nada adicionar um item já existente na lista.
            foreach (Produto item in carrinho)
            {
                Console.WriteLine("{0}: {1} - {2} x {3}", /*carrinho.IndexOf(item) + 1*/"semitem", item.Nome, item.Preco, item.Quantidade);
            }

            Console.WriteLine("{0} => tamanho do carrinho", carrinho.Count);

            List<Produto> teste = new List<Produto>(){
                new Produto(10, "oi", 10),
                new Produto(10, "afda", 110),
                new Produto(10, "ofdafai", 120)
            };

            // Adicionando um intervalo
            carrinho.UnionWith(teste);
            Produto adiciona = new Produto(10, "oi", 10);
            carrinho.Add(adiciona);
            Console.WriteLine("{0} => tamanho do carrinho", carrinho.Count);
            carrinho.Add(adiciona);
            Console.WriteLine("{0} => tamanho do carrinho", carrinho.Count);
        }
    }
}

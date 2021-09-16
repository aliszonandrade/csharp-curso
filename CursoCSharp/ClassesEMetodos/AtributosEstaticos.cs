using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {
        class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto()
            {

            }

            public double CalcularPrecoDescontado()
            {
                return Preco - Preco * Desconto;
            }

        }

        public static void Executar()
        {
            Produto prod1 = new Produto()
            {
                Nome = "Produto Um",
                Preco = Double.Parse(Console.ReadLine())
            };

            Console.WriteLine($"Valor do produto '{prod1.Nome}' descontado: " + prod1.CalcularPrecoDescontado());
            
            Produto prod2 = new Produto("Produto Dois", Double.Parse(Console.ReadLine()), 0.9);
            Console.WriteLine($"Valor do produto '{prod2.Nome}' descontado: " + prod2.CalcularPrecoDescontado());
        }
    }
}

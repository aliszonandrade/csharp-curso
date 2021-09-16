using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Preencha seus dados");
                Pessoa sicrano = new Pessoa();
                sicrano.Nome = Console.ReadLine();
                int.TryParse(Console.ReadLine(), out int entrada);
                sicrano.Idade = entrada;
                Console.WriteLine(sicrano.Apresentar());
                bool resposta = !true;
                while (resposta == !true)
                {
                    Console.WriteLine("Deseja continuar?");
                    string ler = Console.ReadLine().ToLower();

                    if (ler == "n")
                    {
                        continuar = false;
                        resposta = true;
                    }
                    else if (ler == "s")
                    {
                        continuar = true;
                        resposta = true;
                    }
                    else
                    {
                        sicrano.Zerar();
                        Console.WriteLine(sicrano.Apresentar());
                        resposta = false;
                    }
                }
            }
        }
    }
}

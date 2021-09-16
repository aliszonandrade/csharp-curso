using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            bool continuar = true;
            int olas = 0;

            while (continuar)
            {
                Random aleatorio = new Random();
                int qtdRepet = aleatorio.Next(1, 100);
                olas += qtdRepet;
                for (int passo = 1; passo <= qtdRepet; passo++)
                {
                    Console.Write($"{qtdRepet} ");
                    
                }

                Console.WriteLine("Deseja continuar a executar?");
                string entrada = Console.ReadLine();
                entrada.ToLower();
                if(entrada == "s")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }

            }
            Console.WriteLine($"Quantidade de 'Olás' em tela {olas}");

        }

        }         
    }


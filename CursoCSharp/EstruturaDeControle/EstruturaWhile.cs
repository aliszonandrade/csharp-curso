using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            bool executar = false;

            while (!executar)
            {
            int palpite = 0;
            Random teste = new Random();
            int numeroSecreto = teste.Next(1, 16);
            bool numeroEncontrado = false;  
            int tentativasRestantes = 5;
            int tentativas = 0;

                while (tentativasRestantes > 0 && !numeroEncontrado)
                {
                    Console.WriteLine("Digite um número de 1 a 15");
                    string Entrada = Console.ReadLine();
                    int.TryParse(Entrada, out palpite);

                    tentativas++;
                    tentativasRestantes--;

                    if (palpite == numeroSecreto)
                    {
                        numeroEncontrado = true;
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Parabéns, você acertou! Número de tentativas {tentativas}");
                        Console.BackgroundColor = corAnterior;

                        Console.WriteLine("Continuar? 0 para não, 1 para sim");
                        int.TryParse(Console.ReadLine(), out int continuar);
                        if (continuar == 0)
                        {
                            executar = true;
                        }
                    }
                    else if (palpite > numeroSecreto)
                    {
                        Console.WriteLine("O número é menor. Tente novamente");
                        Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                    }
                    else
                    {
                        Console.WriteLine("O número é maior. Tente novamente");
                        Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                    }
                }
            }
        }
    }
}

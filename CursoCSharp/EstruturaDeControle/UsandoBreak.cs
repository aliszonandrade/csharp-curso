using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random aleatoriedade = new Random();
            int numero = aleatoriedade.Next(1, 51);
            Console.WriteLine($"Número que queremos: {numero}");
            for(int passo = 50; passo >= 1; passo--)
            {
                Console.Write($"O número {passo} é o que queremos? ");
                if (numero == passo)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
        }
    }
}

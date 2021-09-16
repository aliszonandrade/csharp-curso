using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;
            Console.WriteLine("Digite a nota:");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Pilantrinha!");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Vacilão do caralho");
            }
            Console.WriteLine(nota);
        }
    }
}

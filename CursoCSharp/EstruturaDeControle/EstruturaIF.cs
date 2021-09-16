using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento;
            string entrada;

            Console.WriteLine("Qual nota obteve?");
            entrada = Console.ReadLine();

            Double.TryParse(entrada, out double nota);
            Console.WriteLine("Obteve bom comportamento (S/N):");
            entrada = Console.ReadLine();
            bomComportamento = entrada.ToUpper() == "S";
            
            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra");
            }

            Console.WriteLine(nota);
            Console.WriteLine(bomComportamento);
        }
    }
}

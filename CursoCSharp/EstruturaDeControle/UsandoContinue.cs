using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            Console.WriteLine("Quais os números pares\nDe 0 a ___ ?");
            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine("De 0 a {0} existem os seguintes números pares: ", numero);
            for(int i = 0; i <= numero; i++)
            {
                if(i%2 == 1)
                {
                    continue;
                }

                Console.Write("{0} ", i);
            }

        }
    }
}

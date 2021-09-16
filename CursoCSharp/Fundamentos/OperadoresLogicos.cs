using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho = false;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho && executouTrabalho2;
            Console.WriteLine($"Comprou a TV 50? {comprouTv50}");

            bool comprouSorvete = executouTrabalho || executouTrabalho2;
            Console.WriteLine("Comprou o Sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 32? {0}", comprouTv32);

            Console.WriteLine("Compra mais saudável? {0}", !comprouSorvete);
        }
    }
}

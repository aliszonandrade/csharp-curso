using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -4;
            var numero1 = 2;
            var numero2 = 9;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//inverte o sinal do valor
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == numero2++);
            Console.WriteLine($"{numero1} {numero2}");

            
        }
    }
}

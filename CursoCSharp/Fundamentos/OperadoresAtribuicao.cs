using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;

            num1 = 7;
            num1 += 10;
            num1 -= 2;
            num1 *= 64;
            num1 /= 3;

            Console.WriteLine(num1);

            var a = 5;
            var b = a;
            a++;
            a++;
            a--;
            Console.WriteLine($"A: {a} B: {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine($"O nome no c é: {c.nome}");


        }
    }
}

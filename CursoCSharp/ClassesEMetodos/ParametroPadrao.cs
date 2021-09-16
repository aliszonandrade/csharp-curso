using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Subtrair(int maior = 1, int menor = 1)
        {
            return maior - menor;
        }

        public static void Executar()
        {
            Console.WriteLine(Subtrair(8,4));
            Console.WriteLine(Subtrair(8));
            Console.WriteLine(Subtrair(menor: 7));
            Console.WriteLine(Subtrair());
        }
    }
}

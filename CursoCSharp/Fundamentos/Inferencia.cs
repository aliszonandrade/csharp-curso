using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //variável implícita
            var nome = "Leonardo";

            var idade = 32;

            Console.WriteLine("O nome dele é: " + nome + "\nA idade dele é: " + idade);

            //apenas declarando a variável
            int a;
            a = 18;
            //declarando e inicializando a variável
            int b = 19;

            Console.WriteLine("Soma de valores: " + (a + b));
        }
    }
}

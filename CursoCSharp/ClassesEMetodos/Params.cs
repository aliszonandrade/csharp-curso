using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        // necessário apenas utilizar a "params" e um array.
        // os parâmetros são variaveis (não há um valor definido de quantidade)

        public static void Recepcionar(params string[] pessoas)
        {
            foreach (string people in pessoas)
            {
                Console.WriteLine($"Olá, {people}");
            }            
        }

        public static void DataNascimento(params DateTime[] data)
        {
            foreach (var item in data)
            {
                Console.WriteLine("Você nasceram respectivamente em: {0}", item);
            }
        }
        
        public static void Executar()
        {
            Recepcionar("Alisson", "Anderson", "Maria");
            DataNascimento(new DateTime(1998, 10, 14), new DateTime(1976, 12, 22), new DateTime(1963, 03, 25));
        }
    }
}

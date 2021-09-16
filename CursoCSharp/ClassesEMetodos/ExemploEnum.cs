using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Beleza { Horrivel, Feia, Morna, Bonita, Linda }

        class Mulher
        {
            public string Nome;
            public Beleza nivelBeleza;
        }

        public static void Executar()
        {
            var mulher = new Mulher();
            mulher.Nome = Console.ReadLine();
            mulher.nivelBeleza = Beleza.Linda;
            Console.WriteLine("{0} é {1}", mulher.Nome, mulher.nivelBeleza);
            Console.WriteLine("Nível da beleza: {0} estrelas", (int) mulher.nivelBeleza+1);

        }
    }
}

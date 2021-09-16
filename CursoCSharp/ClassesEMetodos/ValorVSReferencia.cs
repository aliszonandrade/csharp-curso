using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVSReferencia
    {
        public static void Executar()
        {
            Dependente dependente = new Dependente { Nome = "Alisson", Idade = 21 };
            Dependente novoDependente = dependente;

            Console.WriteLine("{0} {1}", dependente.Nome, dependente.Idade);
            Console.WriteLine("{0} {1}", novoDependente.Nome, novoDependente.Idade);

            novoDependente.Nome = "Anderson";
            dependente.Idade = 43;

            Console.WriteLine("{0} {1}", dependente.Nome, dependente.Idade);
            Console.WriteLine("{0} {1}", novoDependente.Nome, novoDependente.Idade);


        }
    }
}

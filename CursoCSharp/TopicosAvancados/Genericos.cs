using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }
        
        public Caixa(T coisa)
        {
            Coisa = coisa;
        }

        public T RetornaAlgo(T valor)
        {
            return new Random().Next(0, 2) == 0 ? valor : Coisa;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0)
        {
        }

    }

    class Genericos
    {
        public static void Executar()
        {
            Caixa<double> caixa = new Caixa<double>(14);
            Console.WriteLine($"{caixa.GetType()}");
            Console.WriteLine($"{caixa.RetornaAlgo(19)}");

            Caixa<string> caixa2 = new Caixa<string>(null);
            Console.WriteLine($"{caixa2.RetornaAlgo("teste2")} {caixa2.GetType()}");
        }
    }
}

using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("c"));
            Console.WriteLine(valor.ToString("p"));
            Console.WriteLine(valor.ToString("#.####"));

            CultureInfo cultura = new CultureInfo("en-us");
            Console.WriteLine(valor.ToString("c2", cultura));

            int teste = 18198;
            Console.WriteLine(teste.ToString("D30"));

        }
    }
}

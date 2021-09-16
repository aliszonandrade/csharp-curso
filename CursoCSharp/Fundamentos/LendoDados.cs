using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salário? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Qual sua profissão? ");
            string profissao = Console.ReadLine();

            Console.WriteLine($"{nome} trabalha como {profissao}. Aos {idade} anos," +
                $"já recebe R${salario} como salário bruto.");
        }
    }
}

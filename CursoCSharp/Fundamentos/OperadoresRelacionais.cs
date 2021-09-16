using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota");
            double.TryParse(Console.ReadLine(), out double nota);
            var notaDeCorte = 8.0;
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Nota inválida? {0}", nota > 10);
            Console.WriteLine("Passou? {0}", nota > notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 5);
            Console.WriteLine("Perfeito? {0}", nota == 10);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);

        }
    }
}

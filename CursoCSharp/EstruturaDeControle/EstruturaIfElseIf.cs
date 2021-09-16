using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno:");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            //Por conta de estar em sentença única, não foi necessário criar blocos de códigos
            if (nota >= 9) Console.WriteLine("Quadro de honra");
            else if (nota >= 7) Console.WriteLine("Aprovado!");
            else if (nota >= 5) Console.WriteLine("Recuperação");
            else Console.WriteLine("Reprovado");

            //if (nota >= 9)
            //{
            //    Console.WriteLine("Quadro de honra");
            //}
            //else if (nota >= 7)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else if (nota >= 5)
            //{
            //    Console.WriteLine("Recuperação");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado");
            //}

            Console.WriteLine($"Nota tirada: {nota}");
        }
    }
}

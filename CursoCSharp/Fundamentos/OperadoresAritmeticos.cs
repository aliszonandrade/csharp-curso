using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço desconto
            var preco = 1000.90;
            var imposto = 390;
            var desconto = 0.1;
            double Total = preco + imposto;
            var TotalComDesconto = preco - Total * desconto;
            Console.WriteLine("O valor com desconto é {0}" , TotalComDesconto);

            //IMC
            double peso = 54.759;
            double altura = 1.89;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC é de {imc}");

            //Par/Impar
            int par = 28;
            int impar = 17;
            Console.WriteLine("O número {0} tem resto {1}", par, par%2);
            Console.WriteLine("Já o número {0} tem resto {1}", impar, impar%2);


        }
    }
}

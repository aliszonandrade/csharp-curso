using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.15;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine("Para um raio de " + raio);
            Console.WriteLine("A área é: " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte maxidade = byte.MaxValue;
            Console.WriteLine("Maior valor do byte: " + maxidade);
            byte idade = byte.MinValue;
            Console.WriteLine("Menor valor do byte: " + idade);

            sbyte maxnaoSei = sbyte.MaxValue;
            Console.WriteLine("Maior valor do sbyte: " + maxnaoSei);
            sbyte naoSei = sbyte.MinValue;
            Console.WriteLine("Menor valor do sbyte: " + naoSei);

            short maxvariavel = short.MaxValue;
            Console.WriteLine("Maior valor do short " + maxvariavel);
            short variavel = short.MinValue;
            Console.WriteLine("Menor valor do short " + variavel);

            int errovariavel = int.MaxValue;
            Console.WriteLine("Maior valor do inteiro: " + errovariavel);
            int intsvariavel = int.MinValue;
            Console.WriteLine("Menor valor do inteiro: " + intsvariavel);

            uint populacaoBrasileira = 200_600_000;
            Console.WriteLine("A população brasileira é de: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor do long " + menorValorLong);

            float valorDeAlgo = 1300.92f;
            Console.WriteLine("O valor float é: " + valorDeAlgo);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal valorAstronomico = decimal.MaxValue;
            Console.WriteLine("Valor astronômico: " + valorAstronomico);

            char letra = 'b';
            Console.WriteLine("Letra utilizada: " + letra);

            string frase = "Finalizada mais uma aula de C#";
            Console.WriteLine(frase);


        }
    }
}

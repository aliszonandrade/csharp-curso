using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public void TodasOperacoes(int valor1, int valor2)
        {
            Console.WriteLine("A soma dos valores inseridos é: " + Somar(valor1, valor2));
            Console.WriteLine("A multiplicação dos valores inseridos é: " + Multiplicar(valor1, valor2));
            Console.WriteLine("A divisão dos valores inseridos é: " + Dividir(valor1, valor2));
            Console.WriteLine("A subtração dos valores inseridos é: " + Subtrair(valor1, valor2));
        }


        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public float Dividir(float a, float b)
        {
            return a / b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

    }

    class CalculadoraEncadeada
    {
        int memoria;

        public CalculadoraEncadeada Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraEncadeada Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraEncadeada Subtrair(int b)
        {
            memoria -= b;
            return this;
        }

        public CalculadoraEncadeada Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            int primeiroValor;
            int segundoValor;

            Console.WriteLine("Insira o primeiro e o segundo valor");
            int.TryParse(Console.ReadLine(), out primeiroValor);
            int.TryParse(Console.ReadLine(), out segundoValor);

            CalculadoraComum teste = new CalculadoraComum();
            teste.TodasOperacoes(primeiroValor, segundoValor);

            Console.WriteLine("\nDeseja inverter os números das operações?");
            if (Console.ReadLine().ToUpper() == "S")
            {
                teste.TodasOperacoes(segundoValor, primeiroValor);
            }

            Console.WriteLine("\n\nAPI:");
            CalculadoraEncadeada calculatorAPI = new CalculadoraEncadeada();
            calculatorAPI.Somar(primeiroValor).Multiplicar(primeiroValor).Subtrair(segundoValor).Imprimir();


        }

    }
}

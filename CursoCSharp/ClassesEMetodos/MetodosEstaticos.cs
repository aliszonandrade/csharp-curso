using System;
using System.Collections.Generic;
using System.Text;

// O método estático faz com que não possa ser utilizado na instância de objeto.
// É possível utilizar apenas na classe. Por tanto, uma única vez.
// Diferente das instância de objeto que podem ser feita várias.
namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public int SomarInstanciado(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
     
        public static void Executar()
        {
            int v1;
            int v2;

            Console.WriteLine("Digite dois valores para ser instanciados.");
            int.TryParse(Console.ReadLine(), out v1);
            int.TryParse(Console.ReadLine(), out v2);

            CalculadoraEstatica calculator = new CalculadoraEstatica();
            Console.WriteLine("Soma (instanciada de um objeto): " +  calculator.SomarInstanciado(v1, v2));

            Console.WriteLine("Soma (direta da classe): " + CalculadoraEstatica.Somar(v1, v2));

        }
    }
}



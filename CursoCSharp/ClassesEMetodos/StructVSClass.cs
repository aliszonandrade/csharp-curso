using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    struct SPonto
    {
        public int X;
        public int Y;
    }

    class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVSClass
    {
        public static void Chama()
        {
            Console.WriteLine("A struct faz a atribuição por valor\nQuanto a class faz a atribuição por referência.\n" +
                "Isto é, ao instanciar uma classe e duplicar, ela apontará pro mesmo local de memória.");
            Console.WriteLine("\nStruct");
            SPonto teste = new SPonto { X = 10, Y = 15 };
            SPonto novoTeste = teste;
            teste.X = 0;

            Console.WriteLine("Valor de (teste) X: {0}", teste.X);
            Console.WriteLine("Valor de (novoTeste) X: {0}", novoTeste.X);

            Console.WriteLine("\nClass");
            CPonto testeClasse = new CPonto { X = 10, Y = 15 };
            CPonto newTesteClasse = testeClasse;
            testeClasse.X = 0;

            Console.WriteLine("Valor de (testeClasse) X: {0}", testeClasse.X);
            Console.WriteLine("Valor de (newTesteClasse) X: {0}", newTesteClasse.X);
        }
    }
}

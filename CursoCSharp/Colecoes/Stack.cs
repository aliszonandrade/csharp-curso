using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            Stack primeiraStack = new Stack();
            primeiraStack.Push("Alisson");
            primeiraStack.Push(true);
            primeiraStack.Push(new DateTime(1998, 10, 14));
            primeiraStack.Push(2);
            primeiraStack.Push(14.91);

            foreach (var item in primeiraStack)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek: {primeiraStack.Peek()}");
            Console.WriteLine($"Quantidade: {primeiraStack.Count}\n\n");
            
            Console.WriteLine($"\nPop: {primeiraStack.Pop()}");
            Console.WriteLine($"Quantidade: {primeiraStack.Count}\n\n");

            foreach (var item in primeiraStack)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}

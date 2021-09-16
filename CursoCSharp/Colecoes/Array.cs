using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            int soma = 0;

            string[] arrayString = new string[5];
            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine("Insira a nota");
                arrayString[i] = Console.ReadLine();
            }

            foreach (var item in arrayString)
            {
                soma += int.Parse(item);
            }

            int media = soma / arrayString.Length;
            Console.WriteLine("A média do grupo é igual a: {0}", media);

            int[] numeroAluno = new int[5];
            for (int i = 0; i < arrayString.Length; i++)
            {
                numeroAluno[i] = i;
                arrayString[i] = Console.ReadLine();
            }

            foreach (var item in numeroAluno)
            {
                Console.WriteLine("Código do aluno {0}", item);
            }

            foreach (var item in arrayString)
                Console.WriteLine("Nome: {0}", item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            int qtd = 0;
            string palavra = "Alisson";
            foreach(char letra in palavra)
            {
                Console.Write($"{letra} ");
            }

            var alunos = new string[] {"Olá", "Sim", "Tudo joia", "Magavilha"};
            foreach(string aluno in alunos)
            {
                qtd += 1;
            }
            Console.WriteLine("Quantidade de alunos: {0}", qtd);
        }
    }
}

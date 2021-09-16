using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            Dictionary<int, string> pessoas = new Dictionary<int, string>();
            pessoas.Add(1, "Alisson");
            pessoas.Add(2, "Maria do Carmo");
            pessoas.Add(3, "Anderson");
            pessoas.Add(4, "Antonio");
            pessoas.Add(5, "Antonia");

            Console.WriteLine("Lista abaixo:");
            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contain a chave 3?");
            Console.WriteLine("3: {0}", pessoas.GetValueOrDefault(3, "Non ecziste"));
            
             

            Console.WriteLine("Contain a chave 9?");
            Console.WriteLine("9: {0}", pessoas.GetValueOrDefault(9, "Non ecziste"));

            Console.WriteLine("Contém Ana?");
            Console.WriteLine(pessoas.ContainsValue("Ana"));

            Console.WriteLine("Removeu o 6?" + pessoas.Remove(6));

            Console.WriteLine(pessoas.TryGetValue(9, out string pessoaFoda));
            Console.WriteLine(pessoas.TryGetValue(1, out string pessoaFodaDnv));

            Console.WriteLine("Percorrendo keys");
            foreach (var item in pessoas.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in pessoas.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<int, string> pessoa in pessoas)
            {
                Console.WriteLine($"A pessoa {pessoa.Value} possui a importância de número {pessoa.Key}");
            }

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"\nA pessoa {pessoa.Value} possui a importância de número {pessoa.Key}");
            }
        }
    }
}

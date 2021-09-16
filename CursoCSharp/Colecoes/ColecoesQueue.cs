using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Alisson");
            fila.Enqueue("Carla");
            fila.Enqueue("Erika");

            // Pega o primeiro da fila sem removê-lo
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            fila.Dequeue();
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            fila.Enqueue("Hey");
            fila.Enqueue("Ho");
            fila.Enqueue("Let's go");

            foreach (var item in fila)
            {
                Console.Write(item + " ");
            }

            Queue saladaoTipos = new Queue();
            saladaoTipos.Enqueue("foda-se");
            saladaoTipos.Enqueue(true);
            saladaoTipos.Enqueue(1.12);
            saladaoTipos.Enqueue(3);

            foreach (var item in saladaoTipos)
            {
                Console.WriteLine("O item {0} do tipo {1} não foi removido", item.ToString(), item.GetType());
            }

            Console.WriteLine(saladaoTipos.Contains("foda-se"));


        }
    }
}

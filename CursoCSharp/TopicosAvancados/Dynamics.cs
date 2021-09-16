using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 4;
            meuObjeto++;

            Console.WriteLine(meuObjeto);


            dynamic objetoDinamica = new ExpandoObject();
            objetoDinamica.Ola = "Eu atribuo qualquer merda";
            objetoDinamica.Idade = 29;
            int? Idade2 = 90;

            Console.WriteLine(objetoDinamica);
            Console.WriteLine($"{objetoDinamica.Ola} {objetoDinamica.Ola.GetType()}");
            Console.WriteLine($"{objetoDinamica.Idade} {objetoDinamica.Idade.GetType()}");
            Console.WriteLine($"{Idade2} {Idade2.GetType()}");


        }
    }
}

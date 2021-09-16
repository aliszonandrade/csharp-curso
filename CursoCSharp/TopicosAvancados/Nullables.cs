using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            //Formato que permite que seja passado nulo para os tipos não nulos.
            Nullable<int> num = null;
            int? num2 = null;

            if(num.HasValue)
                Console.WriteLine($"A variável possui valor: {num}");
            else
                Console.WriteLine($"A varíavel do não possui valor");

            int numNotNull = num.GetValueOrDefault();

            Console.WriteLine(numNotNull);
        }
    }
}

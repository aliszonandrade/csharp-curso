using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ExemploArrayList
    {
        public static void Executar()
        {
            ArrayList oi = new ArrayList
            {
                "Foda-se",
                2,
                69.69,
                true,
                new DateTime(1010, 10, 10)
            };

            foreach (var item in oi)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}

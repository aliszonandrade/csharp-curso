using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        // Atributo de instância
        int a = 10;

        public static void Executar()
        {
            var teste = new DesafioAtributo();
            Console.WriteLine(teste.a);
        }
    }
}

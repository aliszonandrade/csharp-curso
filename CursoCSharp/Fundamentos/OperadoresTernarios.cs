using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 7;
            bool comportamento = false;
            var resultado = nota >= 7.0 ^ comportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}

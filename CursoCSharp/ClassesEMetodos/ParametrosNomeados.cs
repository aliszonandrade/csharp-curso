using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void TratamentoNomeados(string nome, int idade, int dia, int mes, int ano)
        {
            Console.WriteLine($"Olá {nome}, bom saber que você possui {idade} anos. E foi nascido em {dia:D2}/{mes:D2}/{ano:D4}");
        }

        public static void Executar()
        {
            TratamentoNomeados(dia: int.Parse(Console.ReadLine()), ano: int.Parse(Console.ReadLine()), nome: "Alisson", 
                mes: int.Parse(Console.ReadLine()), idade: int.Parse(Console.ReadLine()));
        }
    }
}

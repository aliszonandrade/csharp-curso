using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            var marca = "Dell";
            double preco = 2000.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            //Interpolação, uma forma mais simples de juntar strings e variáveis.
            Console.WriteLine("O preço de {0} corresponde ao  {1} da marca {2}", preco, nome, marca);

            //Outra forma de interpolação, para que deste modo funcione, é necessário colocar um '$'
            Console.WriteLine($"A marca é: {marca} do {nome}");

            Console.WriteLine($"Interpolação de soma 1 + 17 = {1 + 17}");
        }
    }
}

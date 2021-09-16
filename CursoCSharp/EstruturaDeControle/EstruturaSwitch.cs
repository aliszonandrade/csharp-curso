using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie minha inteligência de 0 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {                
                case 1:
                    Console.WriteLine("Péssimo");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Excelente!");
                    break;
                default:
                    Console.WriteLine("Nota digitada é inválida");
                    break;
            }
            Console.WriteLine("Teste");
        }
    }
}

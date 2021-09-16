using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CarroOpcional
    {
        string nome;
        double desconto = 0.2;

        public string Nome
        {
            get
            {
                return "Opcional" + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Get / Set auto implementado
        public double Preco { get; set; }

        //Apenas o get aplicado, então é somente leitura. (uma estratégia geralmente utilizada para campos calculados).
        public double PrecoComDesconto
        {
            get
            {
                return Preco - (Preco * desconto);
            }
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            CarroOpcional adicional1 = new CarroOpcional("Ar-condicionado", 2000);
            Console.WriteLine(adicional1.Nome);
            Console.WriteLine(adicional1.Preco);
            Console.WriteLine(adicional1.PrecoComDesconto);

            CarroOpcional adicional2 = new CarroOpcional();

            adicional2.Nome = "Vidro trava elétrica";
            adicional2.Preco = 2500;
            Console.WriteLine(adicional2.Nome);
            Console.WriteLine(adicional2.Preco);
            Console.WriteLine(adicional2.PrecoComDesconto);
        }
}
}

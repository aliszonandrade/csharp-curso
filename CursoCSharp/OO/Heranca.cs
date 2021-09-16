using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int velocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = velocidadeAtual + delta;

            if (novaVelocidade < 0)
                velocidadeAtual = 0;
            else if (novaVelocidade > VelocidadeMaxima)
                velocidadeAtual = VelocidadeMaxima;
            else
                velocidadeAtual = novaVelocidade;

            return velocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(140)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(380)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Estratégia para não precisar marcar o método da classe pai como virtual
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Frear()); 
            Console.WriteLine(carro1.Frear()); 
            Console.WriteLine(carro1.Frear()); 
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari");
            var carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            //Polimorfismo
            Console.WriteLine("Ferrari com tipo Carro..");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}

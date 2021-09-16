using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Corsa";
            carro1.Fabricante = "GM";
            carro1.Ano = 2001;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Oi",2001);
        }
    }
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }
        public Carro()
        {

        }
    }
}

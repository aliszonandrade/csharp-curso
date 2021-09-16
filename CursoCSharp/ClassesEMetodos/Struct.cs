using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface PontoCardinais
    {
        void MoverNaDiagonal(int valor);
    }

    struct Coordenada : PontoCardinais 
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int teste)
        {
            X += teste;
            Y += teste;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 10;
            coordenadaInicial.Y = 14;
            Console.WriteLine("Valores iniciais -- X: {0} | Y: {1}", coordenadaInicial.X, coordenadaInicial.Y);
            coordenadaInicial.MoverNaDiagonal(2);
            Console.WriteLine("Valores iniciais -- X: {0} | Y: {1}", coordenadaInicial.X, coordenadaInicial.Y);

            var novaCoordenada = new Coordenada(12, 13);
            novaCoordenada.MoverNaDiagonal(-3);
            Console.WriteLine("Valores iniciais -- X: {0} | Y: {1}", novaCoordenada.X, novaCoordenada.Y);
        }
    }
}

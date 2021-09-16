using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class RefVSOut
    {
        public static void AlterarReferencia(ref int a)
        {
            a += 1000;
        }

        public static void AlterarOut(out int b)
        {
            b = 0;
            b += 1000;
        }

        public static void Executar()
        {
            int referencia = 2;
            Console.WriteLine("Enviado: {0} - ref", referencia);
            AlterarReferencia(ref referencia);
            Console.WriteLine("Bi-direcional: enviamos e recebemos o valor");
            Console.WriteLine(referencia);

            int outReferencia = 2;
            Console.WriteLine("\nEnviado: {0} - out", outReferencia);
            AlterarOut(out outReferencia);
            Console.WriteLine("Uni-direcional: apenas recebemos o valor (não pode ser atribuido fora do método)");
            Console.WriteLine(outReferencia);
        }
    }
}

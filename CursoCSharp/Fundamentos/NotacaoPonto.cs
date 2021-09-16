using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace("World","Mundo").ToUpper();
            Console.WriteLine(saudacao);
            
            //Utilizar a notação ponto com um valor nulo, é arriscado, pois não há nada definido por conta de ser nulo
            //Muito possivelmente, iremos ter um problema de Object not instance references
            string valorImportante = "123";

            //Para que não seja apresentado este problema, podemos colocar um '?' antes da notação '.'
            //Esta estratégia adotado de colocar um ponto e vírgula, chamamos de navegação segura.
            //Pois, não gera o erro.
            Console.WriteLine(valorImportante.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    //ReadOnly uma espécie de constante para objetos.
    // Configura apenas uma vez (na construção do objeto)
    class Cliente
    {
        public string Nome;
        readonly public DateTime DtNascimento;

        public string GetDtNascimento()
        {
            return String.Format($"{DtNascimento.Day}/{DtNascimento.Month}/{DtNascimento.Year}");
        }

        public Cliente(DateTime nascimento)
        {
            DtNascimento = nascimento;
        }

    }

    class ReadOnly
    {
        public static void Executar()
        {
            Cliente novoCliente = new Cliente(new DateTime(1998, 10, 14));
            //Não funfa desta maneira. 
            //novoCliente.DtNascimento = new DateTime(1998, 10, 14);
            novoCliente.Nome = "Alisson";
            Console.WriteLine($"{novoCliente.Nome}\n{novoCliente.GetDtNascimento()}");


            
        }
    }
}

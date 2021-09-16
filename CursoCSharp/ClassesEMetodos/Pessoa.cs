using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Mensagem = ("Olá, digite seu nome.");

        public string Apresentar()
        {
            if(Nome == "" || Idade <= 0)
            {
                return ("Os dados preenchidos são inválidos");
            }
            else
            {
                return string.Format($"Olá me chamo {Nome}, tenho {Idade} anos.");
            }
            
        }
        
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    // Relacionado ao princípio de Encapsulamento
    // Get & Set são utilizados para dar apenas a "interface" de uso
    // Acessar atributos a partir de: Métodos de leitura e configuração.
    // Não permitirá acessar diretos aos atributos.

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }

    public class Motociclista
    {
        private string Nome;
        private uint Idade;

        public Motociclista(string nome, uint idade)
        {
            SetNome(nome);
            SetIdade(idade);
        }

        public Motociclista()
        {

        }

        public string GetNome()
        {
            return Nome;
        }

        public uint GetIdade()
        {
            return Idade;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetIdade(uint idade)
        {
            if (idade >= 18)
            {
                Idade = idade;
            }
            else
            {
                Console.WriteLine("Não possui idade para pilotar!");
            }
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            Motociclista motociclista = new Motociclista();
            motociclista.SetNome(Console.ReadLine());
            motociclista.SetIdade(uint.Parse(Console.ReadLine()));

            if (motociclista.GetIdade() >= 18)
            {
                Console.WriteLine("Monte sua moto:");
                Moto moto = new Moto(Console.ReadLine(), Console.ReadLine(), uint.Parse(Console.ReadLine()));

                Console.WriteLine($"Parabéns, {motociclista.GetNome()}\n" +
                    $"Sua primeira moto é uma {moto.GetMarca()} - {moto.GetModelo()} de {moto.GetCilindrada()} cc.");
            }

        }
    }
}

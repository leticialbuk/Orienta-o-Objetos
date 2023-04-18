using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoaA = new Pessoa(1, "Leticia ALbuquerque");
            var pessoaB = new Pessoa(1, "Leticia ALbuquerque");

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Equals(Pessoa other)
        {
            return Id == other.Id;
        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pessoa = new Pessoa();
            //var pessoa = new PessoaFisica();
            //var pessoa = new PessoaJuridica();

            // ex de Upcast:
            var PessoaFisica = new PessoaFisica();

            // ex de Downcast:
            PessoaFisica = (PessoaFisica)pessoa;
        }
    }

    // Aqui vemos que a classe Pessoa é a classe pai ou classe base, enquanto as classes filhas são PessoaFisica/Juridica
    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}
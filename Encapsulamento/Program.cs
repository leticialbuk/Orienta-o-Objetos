using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "1234";


            var pagamento = new Pagamento();

        }

    }

    class Pagamento
    {
        // Propriedades:
        public DateTime Vencimento;

        //Métodos:
        public void Pagar() { }
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;
    }
}
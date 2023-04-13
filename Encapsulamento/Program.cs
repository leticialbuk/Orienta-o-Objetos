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
            pagamento.ToString();
        }
    }

    class Pagamento
    {
        // Propriedades:
        public DateTime Vencimento;

        //Métodos:
        public virtual void Pagar() { }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yy");
        }
    }

    class PagamentoBoleto : Pagamento
    {
        public string? NumeroBoleto;

        public override void Pagar()
        {
            base.Pagar();
            // no poliformismo vc consegue colocar a Regra do boleto
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string? Numero;

        public override void Pagar()
        {
            base.Pagar();
            // no poliformismo vc consegue colocar a Regra do cartão de crédito
        }

    }
}
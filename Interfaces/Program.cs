using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            // aqui voce pode executar algo base como uma validação
        }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoBoleto : Pagamento
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    // Interface dita como uma classe deve ser, I sempre na frente das interfaces
    public interface IPagamento
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
}
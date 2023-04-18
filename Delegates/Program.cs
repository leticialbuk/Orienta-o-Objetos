using System;

namespace MyApp
{
    internal class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de R$ {valor} reais");
        }

        static void Main(string[] args)
        {
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(25);
        }
    }

    // Delegate é usado para apomtar/chamar outra função
    public class Pagamento
    {
        public delegate void Pagar(double valor);

    }
}
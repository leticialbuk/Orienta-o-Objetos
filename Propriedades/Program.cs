using System;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
        }
    }

    public class Pagamento
    {
        public virtual void Pagar(String numero) { }

        // Propriedades:

        // primeira maneira de criar uma propriedade: prop 
        public DateTime Vencimento { get; set; }

        // segunda maneira de criar uma propriedade: propfull
        private DateTime dataPagamento;
        public DateTime DataPagamento
        {
            get
            {
                Console.WriteLine("Lendo valor");
                return dataPagamento.AddDays(1);
            }
            set
            {
                Console.WriteLine("Atribuindo valor");
                dataPagamento = value;
            }
        }

        //Métodos:
        public void Pagar() { }
    }
}
using System;

namespace Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
        }
    }

    //tipos complexos ajuda na quebra de classes, usando referencias uma nas outras
    public class Pagamento
    {
        // Propriedades:
        public DateTime Vencimento;
        //Address BillingAddress;
        //Métodos:
        public void Pagar() { }
    }

    public class Address
    {
        //string ZipCode;
    }
}
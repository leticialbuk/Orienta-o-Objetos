using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            foreach (var item in payments)
            {
                Console.WriteLine(item.Id);
            }

            //First analisa se existe o numero 3 na lista
            var payment = payments.First(x => x.Id == 3);
            Console.WriteLine(payment.Id);
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}
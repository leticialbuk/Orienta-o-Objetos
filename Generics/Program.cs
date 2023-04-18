using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Person();
            var context = new DataContext<Person, Payment, Subscription>();
            context.Save(person);
            context.Save(payment);
            context.Save(subscription);
        }
    }
    // vemos que a classe Genérica pode armazenar mais de um método, independe do tipo:
    public class DataContext<P, PA, S>
        where P : Person
        where PA : Payment
        where S : Subscription
        // where neste caso ele funciona como um limitador 
    {
        public void Save(P entity)
        {

        }

        public void Save(PA entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public class Person { }

    public class Payment { }

    public class Subscription { }
}
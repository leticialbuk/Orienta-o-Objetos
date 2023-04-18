using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //o modificar Sealed sela uma classe, para inibir uma extensão dessa classe
    public sealed class Pagamento
    {
        public DateTime Vencimento { get; set; }
    }

    //exemplo: neste caso eu não consigo chamar o Pagamento, pois não posso derivar de uma classe selada (sealed)
    // public class PagamentoBoleto : Pagamento {}
}
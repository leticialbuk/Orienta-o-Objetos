using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento.Vencimento = DateTime.Now;
            Console.WriteLine("Hello World!");
        }
    }

    //static não é bom na classe pagamento pois existem muitas opcões de pag
    public static class Pagamento
    {
        public static DateTime Vencimento { get; set; }
    }

    //aqui vemos um ex de static, por ser uma configuração a static será usada por toda aplicação, podendo estar na memória 
    partial class Settings
    {
        public static string API_URL { get; set; }
    }
}
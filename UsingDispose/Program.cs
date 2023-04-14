using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using garante a inicio e a finalização do objeto/conexão
            //using só funciona com o IDisposable/Disposable para fazer a implementação
            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando pagamento");
            }

            Console.WriteLine("Hello World!");
        }
    }

    //IDisposable libera recursos não gerenciados
    public class Pagamento : IDisposable
    {
        public Pagamento()
        {
            Console.WriteLine("Iniciando pagamento");
        }

        //Dispose é uma convenção de classes para ligar ao banco e logo depoid liberar sem usar memória
        public void Dispose()
        {
            Console.WriteLine("Finalizando pagamento");
        }
    }
}
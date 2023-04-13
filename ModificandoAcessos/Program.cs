using System;

namespace Payments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
        }
    }

    //modificadores de acessos se estendem em propriedades/métodos/classes são: private, protected, internal e public
    class Pagamento
    {
        // Propriedades:
        public DateTime Vencimento;

        //Métodos:
        public void Pagar() { }
    }

    class PagamentoBoleto : Pagamento
    {
        void Teste()
        {
            //para chamar a classe pai(classe pai seria o Pagamento) usamos o "base. "
        }
    }
}
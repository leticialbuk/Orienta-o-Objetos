using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            //var pagamento = new PagamentoCartao();
            pagamento.Pagar("1234");
        }
    }

    public class Pagamento
    {
        //Aqui temos um método construtor: "octor" ele se inicia quando o bjeto é iniciado 
        public DateTime DataPagamento { get; set; }
        public Pagamento(DateTime vencimento)
        {
            Console.WriteLine("Iniciando pagamento");
            DataPagamento = DateTime.Now;
        }
        //sobrecarga que não recebe nada (constructor parameter): 
        public Pagamento() { }

        //Métodos:
        //Aqui temos dois métodos e chamamos de sobrecarga de método, por ter 2 métodos com nomes iguais(Pagar), mas com assinaturas(string numero...) diferentes
        public virtual void Pagar(string numero)
        {
            Console.WriteLine("Pagar");
        }

        //public void Pagar(string numero, DateTime vencimento) { }
    }

    //Aqui temos duas classes com o nome Pagar, mas usando o vritual e override conseguimos sobre escrever o método
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(DateTime vencimento)
        : base(vencimento)
        {

        }
        public override void Pagar(string numero)
        {
            //para chamar o método Pai usamos o "base. "
            base.Pagar(numero);
            Console.WriteLine("Pagar Cartão");
        }
    }
}
// See https://aka.ms/new-console-template for more information
namespace ExemploBanco;
class Program
{
    class Conta
    {
        public int numeroConta;
        public double saldoConta;
        public int agencia;
        public string proprietario;
    }
    public static void Main(string[] args)
    {
        Conta conta = new Conta();
        conta.saldoConta = 2000;
        conta.proprietario = "Hugo";
        conta.agencia = 3222;
        conta.numeroConta = 23899;
        Console.WriteLine("Número da conta: " + conta.numeroConta);
        Console.WriteLine("Agencia: " + conta.agencia);
        Console.WriteLine("Cilente: " + conta.proprietario);
        Console.WriteLine("Saldo: " + conta.saldoConta);
    }
}

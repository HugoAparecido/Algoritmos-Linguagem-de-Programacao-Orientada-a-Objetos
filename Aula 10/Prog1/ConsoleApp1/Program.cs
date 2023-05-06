using System;
class Conta
{
    //Atributos da Classe Conta
    public string? banco;
    public int numero;
    public int agencia;
    public string? proprietario;
    public double saldo = 10000;
    //Métodos da Classe Conta
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public void Sacar(double valor) 
    {
        this.saldo -= valor;
    }
    public void Extrato()
    {
        Console.WriteLine("Saldo atual: " + this.saldo);
    }
}
class TestaConta
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Conta c = new Conta();
        Console.WriteLine("Informe o Banco");
        c.banco = Console.ReadLine();
        Console.WriteLine("Informe o número da conta");
        c.numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a agência");
        c.agencia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o nome do proprietário");
        c.proprietario = Console.ReadLine();
        c.Depositar(5000);
        c.Sacar(200);
        Console.Clear();
        /*Conta c = new Conta
        {
            banco = "Banco do Brasil",
            numero = 001,
            agencia = 6600,
            proprietario = "Hugo",
            saldo = 1000
        };*/
        Console.WriteLine("Banco: " + c.banco);
        Console.WriteLine("Número: " + c.numero);
        Console.WriteLine("Agência: " + c.agencia);
        Console.WriteLine("Proprietário: " + c.proprietario);
        c.Extrato();
    }                 
}
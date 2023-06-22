using System;
class Conta
{
    //Atributos
    public int numero;
    private double saldo = 2000;
    public string? nomeTitular;
    //Métodos
    public void Saque(double valor)
    {
        this.saldo -= valor;
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public void MostrarSaldo()
    {
        Console.WriteLine("Saldo: " + this.saldo);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Instanciando a classe Conta
        Conta conta = new();
        Console.WriteLine("Efetuar saque da conta? Informe o valor: ");
        double val = Convert.ToDouble(Console.ReadLine());
        conta.Saque(val);
        //conta.saldo -= val;
        conta.MostrarSaldo();
    }
}
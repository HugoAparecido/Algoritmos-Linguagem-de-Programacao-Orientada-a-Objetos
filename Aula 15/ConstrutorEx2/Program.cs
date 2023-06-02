using System;
class CartaoDeCredito
{
    public int numero;
    public string? nome;
    public CartaoDeCredito(int numero) => this.numero = numero;
    // Sobrecarga de Construtores
    public CartaoDeCredito(string titular)
    {
        this.nome = titular;
    }
}
class Agencia
{
    public int numero;
    public Agencia(int numero)
    {
        this.numero = numero;
    }
}
class Conta
{
    Agencia agencia;
    public string? nomeTitular = "Everaldo";
    public Conta(Agencia agencia)
    {
        this.agencia = agencia;
    }
}
class Program
{
    static void Main(string[] args)
    {
        CartaoDeCredito c = new(23456765);
        CartaoDeCredito c1 = new("Everaldo");
        Agencia a = new(0505);
        Conta con = new(a);
        Console.WriteLine("Numero Cartão: " + c.numero);
        Console.WriteLine("Numero Agência: " + a.numero);
        Console.WriteLine("Titular Conta: " + c1.nome);
    }
}
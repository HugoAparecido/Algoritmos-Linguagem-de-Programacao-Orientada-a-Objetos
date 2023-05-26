using System;
class CartaoDeCredito
{
    public int numero;
    public string? nomeTitular;
    public string? operadora;
    public string? validade;
    public int cvc;
    public CartaoDeCredito(int numero)
    {
        this.numero = numero;
    }
}

class Conta
{
    public static void Main(string[] args)
    {
        CartaoDeCredito cartaoDeCredito = new CartaoDeCredito(112233);
        cartaoDeCredito.nomeTitular = "Hugo Aparecido";
        cartaoDeCredito.operadora = "NuBank";
        cartaoDeCredito.validade = "10/12/2030";
        cartaoDeCredito.cvc = 123;
        Console.WriteLine("Titular do Cartão:" + cartaoDeCredito.nomeTitular);
        Console.WriteLine("Operadora " + cartaoDeCredito.operadora);
        Console.WriteLine("Validade: " + cartaoDeCredito.validade);
        Console.WriteLine("CVC: " + cartaoDeCredito.cvc);
    }
}
using System;
class Vendedor
{
    // Atributos da classe Vendedor
    public int numero;
    public string? nome;
    public double salario;
    public string? dataContratacao;
    public string? tipo;
    public double comissao;
    // Métodos da classe Vendedor
    private void Venda(double valorVenda)
    {
        this.salario += valorVenda;
        Console.WriteLine("Venda ocorrida com sucesso, com ganho de " + valorVenda);
    }
    private void Venda(double valorVenda, double comissao)
    {
        this.comissao = comissao;
        this.salario += valorVenda + ((this.comissao/100)*valorVenda);
        Console.WriteLine("Venda ocorrida com sucesso, com ganho de " + (valorVenda + (this.comissao/100 * valorVenda)));
    }
    public void Vender(double valorVenda)
    {
        if(valorVenda < 5000)
        {
            this.Venda(valorVenda);
        }
        else
        {
            this.Venda(valorVenda, 10);
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor();
        Console.WriteLine("Digite o valor da venda:");
        vendedor.Vender(Convert.ToDouble(Console.ReadLine()));
    }
}
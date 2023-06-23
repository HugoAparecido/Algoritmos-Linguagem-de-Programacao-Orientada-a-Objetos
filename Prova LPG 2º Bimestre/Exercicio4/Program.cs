class BancaDoLivro
{
    public string titulo = "este é um bom título";
    public string descricao = "Algo que chame atenção";
    public string autor = "Alguém Importante";
    public string editora = "Mundial";
    public double preco = 30.90;
    public long qtd = 7;
    private double valorTotal;
    public void CalcularvalorTotal()
    {
        this.valorTotal = this.preco * this.qtd;
        if (this.qtd > 1 && this.qtd <= 3)
        {
            this.valorTotal *= 0.9;
        }
        else if (this.qtd > 3)
        {
            this.valorTotal *= 0.75;
        }
        Console.WriteLine("O valor total vendido é R$" + this.valorTotal);
    }
    public void ListarQuantidade()
    {
        Console.WriteLine("A quantidade de livros Vendidos é " + this.qtd);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        BancaDoLivro bancaDoLivro = new();
        bancaDoLivro.CalcularvalorTotal();
        bancaDoLivro.ListarQuantidade();
    }
}
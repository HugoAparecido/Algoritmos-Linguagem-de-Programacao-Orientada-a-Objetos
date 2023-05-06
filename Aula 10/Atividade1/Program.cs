using System;
class Veiculo
{
    //Atributos da Classe Veiculos
    public int codigo;
    public string? fabricante;
    public string? modelo;
    public int ano;
    public double preco = 45000;
    public string? tipoConbustivel;
    public double consumo;
    //Métodos da Classe Veiculo
    public void CalcularPreco()
    {
        switch (this.tipoConbustivel)
        {
            case "gasolina":
                this.preco *= 1.05;
                break;
            case "etanol":
                this.preco *= 1.02;
                break;
            case "flex":
                this.preco *= 1.07;
                break;
            case "Gasolina":
                this.preco *= 1.05;
                break;
            case "Etanol":
                this.preco *= 1.02;
                break;
            case "Flex":
                this.preco *= 1.07;
                break;

        }
    }
    public void CalcularConsumo()
    {
        Console.Write("Informe o valor atual do combustível a ser usado: ");
        var precoCombustivel = Convert.ToDouble(Console.ReadLine());
        this.consumo = (100 / 15 * precoCombustivel);
    }
    public void MostrarDados()
    {
        this.CalcularPreco();
        this.CalcularConsumo();
        Console.WriteLine("Código do Veículo: " + this.codigo);
        Console.WriteLine("Fabricante do Veículo: " + this.fabricante);
        Console.WriteLine("Modelo do Veículo: " + this.modelo);
        Console.WriteLine("Ano de fabricação do Veículo: " + this.ano);
        Console.WriteLine("Preço do Veículo: " + this.preco);
        Console.WriteLine("Tipo de combustível do Veículo: " + this.tipoConbustivel);
        Console.WriteLine("Quantidade de consumo: " + this.consumo);
    }
}
class Program
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Veiculo v = new();
        Console.Write("Informe o código do veículo: ");
        v.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe a fabricante do veículo: ");
        v.fabricante = Console.ReadLine();
        Console.Write("Informe o modelo do veículo: ");
        v.modelo = Console.ReadLine();
        Console.Write("Informe o ano de fabricação do veículo: ");
        v.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o tipo de combustível utilizado: ");
        v.tipoConbustivel = Console.ReadLine();
        v.MostrarDados();
    }
}
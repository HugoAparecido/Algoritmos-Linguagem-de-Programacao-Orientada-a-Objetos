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
        if (this.tipoConbustivel == "gasolina")
        {
            this.preco *= 1.05; 
        }else if(this.tipoConbustivel == "etanol")
        {
            this.preco += 1.02;
        }else if (this.tipoConbustivel == "flex")
        {
            this.preco *= 1.07;
        }
    }
    public void CalcularConsumo()
    {
        Console.Write("Informe o valor atual do combustível a ser usado: ");
        var precoCombustivel = Convert.ToDouble(Console.ReadLine);
        Console.WriteLine("O consumo do veículo para cada quilômetro rodado é : " + ((100 / 15)*precoCombustivel));
        /*100/15*valor*/
    }
    public void MostrarDados()
    {
        Console.WriteLine("Código do Veículo: " + this.codigo);
        Console.WriteLine("Fabricante do Veículo: " + this.fabricante);
        Console.WriteLine("Modelo do Veículo: " + this.modelo);
        Console.WriteLine("Ano de fabricação do Veículo: " + this.ano);
        Console.WriteLine("Preço do Veículo: " + this.preco);
        Console.WriteLine("Tipo de combustível do Veículo: " + this.tipoConbustivel);
        Console.WriteLine("Quantidade de consumo: " + this.preco);
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
        Console.Write("");
    }
}
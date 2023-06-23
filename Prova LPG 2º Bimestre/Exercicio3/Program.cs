using System.Runtime.CompilerServices;

class JogadorFutebol
{
    public string nome = "Almir";
    public string posicao = "Zagueiro";
    public int dataNasc = 1990;
    public string nacionalidade = "Brasileiro";
    public double altura = 1.80;
    public double peso = 65;
    public void ExibirDados()
    {
        Console.WriteLine("Jogador: " + this.nome);
        Console.WriteLine("Posição: " + this.posicao);
        Console.WriteLine("Ano de Nascimento: " + this.dataNasc);
        Console.WriteLine("Nacionalidade: " + this.nacionalidade);
        Console.WriteLine("Altura: " + this.altura);
        Console.WriteLine("Peso: " + this.peso);
    }
    public void CalcularIdade()
    {
        Console.WriteLine("A idade do jogador é " + (2023 - this.dataNasc) + " anos");
    }
}
class Time
{
    public string nome = "AlgumTime";
    public JogadorFutebol? jogadorFutebol;
    public void ExibirNome()
    {
        Console.WriteLine("Time: " + this.nome);
    }
}
class Program
{
   public static void Main(string[] args)
    {
        JogadorFutebol jogadorFutebol = new();
        Time time = new()
        {
            jogadorFutebol = jogadorFutebol
        };
        time.ExibirNome();
        time.jogadorFutebol.ExibirDados();
        time.jogadorFutebol.CalcularIdade();
    }
}
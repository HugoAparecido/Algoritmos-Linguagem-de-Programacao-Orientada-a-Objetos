using System;
class AreaDaForma
{
    public void CalcularArea(int lado)
    {
        Console.WriteLine("A área do quadrado é: " + lado * lado);
    }
    public void CalcularArea(int L1, int L2)
    {
        Console.WriteLine("A área do retângulo é: " + L1 * L2);
    }
    public void CalcularArea(double B, double h)
    {
        Console.WriteLine("A área do triângulo é: " + ((B*h)/2));
    }

}
class Program
{
    public static void Main(string[] args)
    {
        AreaDaForma areaDaForma = new();
        Console.WriteLine("Digite o tipo dde polígono a calcular a área (1-quadrado, 2-retângulo, 3-Triângulo): ");
        int tipo = Convert.ToInt32(Console.ReadLine());
        switch (tipo)
        {
            case 1:
                Console.WriteLine("Digite o tamanho do lado do quadrado em cm: ");
                areaDaForma.CalcularArea(Convert.ToInt32(Console.ReadLine()));
                break;
            case 2:
                Console.WriteLine("Digite o tamanho dos lados do retângulo em cm: ");
                areaDaForma.CalcularArea(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                break;
            case 3:
                Console.WriteLine("Digite respectivamente a base e a altura do triângulo em cm: ");
                areaDaForma.CalcularArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                break;
        }
    }
}
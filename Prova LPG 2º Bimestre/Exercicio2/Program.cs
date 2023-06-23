using System;
class ConversaoDeUnidadesDeTemperatura
{
    public void CelsiusParaFahrenheit(double valorASerConvertido)
    {
        Console.WriteLine("O valor em Fahrenheit é : " + ((valorASerConvertido * 1.8) + 32));
    }
    public void FahrenheitParaCelsius(double valorASerConvertido)
    {
        Console.WriteLine("O valor em Celsius é : " + ((valorASerConvertido -32) / 1.8));
    }
    public ConversaoDeUnidadesDeTemperatura(double valorASerConvertido)
    {
        Console.WriteLine("O valor em Kelvin é : " + (valorASerConvertido + 273.15));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor em Celsius a ser convertido: ");
        double valorAconverter = Convert.ToDouble(Console.ReadLine());
        ConversaoDeUnidadesDeTemperatura conversaoDeUnidadesDeTemperatura = new(valorAconverter);
        Console.WriteLine("Digite qual conversao deseja fazer (1-Celsius para Fahrenheit, 2-Fahrenheit para Celsius)");
        int conversao = Convert.ToInt32(Console.ReadLine());
        switch (conversao)
        {
            case 1:
                conversaoDeUnidadesDeTemperatura.CelsiusParaFahrenheit(valorAconverter);
                break;
            case 2:
                Console.WriteLine("Digite o valor em Fahrenheit a ser convertido: ");
                valorAconverter = Convert.ToDouble(Console.ReadLine());
                conversaoDeUnidadesDeTemperatura.FahrenheitParaCelsius(valorAconverter);
                break;
        }
    }
}
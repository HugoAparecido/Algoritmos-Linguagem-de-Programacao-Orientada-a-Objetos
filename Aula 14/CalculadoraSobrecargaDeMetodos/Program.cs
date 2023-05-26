class Calculadora
{
    //Atributos da classe calculadora
    public double num1;
    public double num2;
    public int num3;
    public int num4;
    //Métodos classe Calculadora
    public double Operacao(double num1, double num2)
    {
        return num1 + num2;
    }
    public double Operacao(int num1, double num2)
    {
        return num1 - num2;
    }
    public double Operacao(double num1, int num2) 
    {

        return num1 * num2;
    }
    public double Operacao(int num1, int num2)
    {

        return num1 / num2;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            Console.WriteLine("Informe a operação que desejas (+, -, *, /)");
            var operacao = Console.ReadLine();
            Console.WriteLine("Informe o primeiro valor: ");
            calculadora.num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            calculadora.num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = calculadora.Operacao(calculadora.num1, calculadora.num2);
                    break;
                case "-":
                    calculadora.num3 = Convert.ToInt32(calculadora.num1);
                    resultado = calculadora.Operacao(calculadora.num3, calculadora.num2);
                    break;
                case "*":
                    calculadora.num3 = Convert.ToInt32(calculadora.num2);
                    resultado = calculadora.Operacao(calculadora.num1, calculadora.num3);
                    break;
                case "/":
                    calculadora.num3 = Convert.ToInt32(calculadora.num1);
                    calculadora.num4 = Convert.ToInt32(calculadora.num2);
                    resultado = (double)calculadora.Operacao(calculadora.num3, calculadora.num4);
                    break;
                default:
                    Console.WriteLine("Operação não aceita!!");
                    break;
            }
            Console.WriteLine("O rsultado da operação é: " + resultado);
        }
    }
}
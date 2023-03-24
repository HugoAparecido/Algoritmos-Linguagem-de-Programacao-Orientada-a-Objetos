namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res, operacao;
            Console.WriteLine("Qual operação quer fazer?\n1:adição\n2:subtralção\n3:multiplicação\n4:divisão");
            operacao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            switch (operacao)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("O resultado é " + res);
                    break;
                case 2:
                    res = num1 - num2;
                    Console.WriteLine("O resultado é " + res);
                    break;
                case 3:
                    res = num1 * num2;
                    Console.WriteLine("O resultado é " + res);
                    break;
                case 4:
                    res = num1 / num2;
                    Console.WriteLine("O resultado é " + res);
                    break;
                default:
                    Console.WriteLine("Valor não aceito!!");
                    break;
            }
        }
    }
}
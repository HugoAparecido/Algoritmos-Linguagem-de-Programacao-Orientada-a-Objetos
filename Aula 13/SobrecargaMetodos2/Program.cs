using System;
namespace SobrecargaMetodos
{
    class Progam
    {
        class Gerente
        {
            //Atributos da classe Gerente
            public string? nome;
            public double salario;
            public long rg;
            public int agencia;
            public string? dataNascimento;
            public string? dataComecoNaGerencia;
            //Métodos da classe Gerente
            public void CadastrarGerente()
            {
                Console.WriteLine("Digite o nome do gerente: ");
                this.nome = Console.ReadLine();
                Console.WriteLine("Digite o rg do gerente: ");
                this.rg = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Digite a agencia do gerente: ");
                this.agencia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a data de nascimento do gerente: ");
                this.dataNascimento = Console.ReadLine();
                Console.WriteLine("Digite em que data tornou-se gerente: ");
                this.dataNascimento = Console.ReadLine();
            }
            public void AumentarSalario()
            {
                this.AumentarSalario(0.1);
            }
            public void AumentarSalario(double taxa)
            {
                this.salario += this.salario * taxa;
            }
        }
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            gerente.CadastrarGerente();
            Console.WriteLine("Digite o salario inicial do gerente: ");
            gerente.salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Para aumentar o salario do gerente seguindo o padrão de 10% digite 1, para colocar outra porcentagem digite 2: ");
            int caso = Convert.ToInt32(Console.ReadLine());
            switch (caso)
            {
                case 1:
                    gerente.AumentarSalario(); break;
                case 2:
                    Console.WriteLine("Digite a porcentagem a ser somada no salário do gerente: ");
                    double porcentagem = (Convert.ToDouble(Console.ReadLine()) / 100);
                    gerente.AumentarSalario(porcentagem); break;
            }
            Console.WriteLine("O gerente " + gerente.nome + " da agencia " + gerente.agencia);
            Console.WriteLine("Salário: " + gerente.salario);
        }
    }
}
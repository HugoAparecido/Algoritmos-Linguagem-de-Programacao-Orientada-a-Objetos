using System;
class Curso
{
    public int idCurso;
    public string? nomeCurso;
    public Curso(int idCurso, string? nomeCurso)
    {
        this.idCurso = idCurso;
        this.nomeCurso = nomeCurso;
    }
}
class Turma
{
    public int idTurma;
    public string? nomeTurma;
    public Turma(int idTurma, string? nomeTurma)
    {
        this.idTurma = idTurma;
        this.nomeTurma = nomeTurma;
    }
}
class Aluno
{
    //Atributos da Classe Aluno
    public int id;
    public string? nomeAluno;
    public double notaBimestre1;
    public double notaBimestre2;
    public double notaBimestre3;
    public double notaBimestre4;
    public Curso? curso;
    public Turma? turma;
    //Construtor da Classe Aluno
    public Aluno(int id, string? nome)
    {
        this.id = id;
        this.nomeAluno = nome;
    }
    //Métodos da Classe Aluno
    public void ColocarNota1()
    {
        this.notaBimestre1 = Convert.ToDouble(Console.ReadLine());
    }
    public void ColocarNota2()
    {
        this.notaBimestre2 = Convert.ToDouble(Console.ReadLine());
    }
    public void ColocarNota3()
    {
        this.notaBimestre3 = Convert.ToDouble(Console.ReadLine());
    }
    public void ColocarNota4()
    {
        this.notaBimestre4 = Convert.ToDouble(Console.ReadLine());
    }
    public double CalcularMedia(double n1, double n2)
    {
        return ((n1 + n2) / 2);
    }
    public double CalcularMedia(double n1, double n2, double n3, double n4)
    {
        return ((n1 + n2 + n3 + n4) / 4);
    }
    public void MostrarStatus()
    {

        if (this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4) >= 6)
        {
            Console.WriteLine("Aluno Aprovado com a média " + this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4));
        }
        else if (this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4) < 6 && this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4) >= 3)
        {
            Console.WriteLine("Aluno em Recuperação com a média " + this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4));
        }
        else
        {
            Console.WriteLine("Aluno Reprovado com a média " + this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4));
        }
    }
    public void RelatorioAluno()
    {
        Console.WriteLine("Aluno: " + this.nomeAluno);
        Console.WriteLine("Matrícula: " + this.id);
        Console.WriteLine("Nota Primeiro Bimestre: " + this.notaBimestre1);
        Console.WriteLine("Nota Segundo Bimestre: " + this.notaBimestre2);
        Console.WriteLine("Nota Terceiro Bimestre: " + this.notaBimestre3);
        Console.WriteLine("Nota Quarto Bimestre: " + this.notaBimestre4);
        Console.WriteLine("Média do primeiro semestre: " + this.CalcularMedia(this.notaBimestre1, this.notaBimestre2));
        Console.WriteLine("Média do segundo semestre: " + this.CalcularMedia(this.notaBimestre3, this.notaBimestre4));
        Console.WriteLine("Média final: " + this.CalcularMedia(this.notaBimestre1, this.notaBimestre2, this.notaBimestre3, this.notaBimestre4));
        Console.Write("Status: ");
        this.MostrarStatus();
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Aluno[] aluno = new Aluno[5];
        int id = 1;
        for (int i = 0; i < aluno.Length; i++)
        {
            Console.WriteLine("Digite respectivemente o prontuário do aluno e seu nome: ");
            aluno[i] = new Aluno(Convert.ToInt32(Console.ReadLine()), nome: Console.ReadLine());
            Console.WriteLine("Digite a nota do primeiro bimestre: ");
            aluno[i].ColocarNota1();
            Console.WriteLine("Digite a nota do segundo bimestre: ");
            aluno[i].ColocarNota2();
            Console.WriteLine("Digite a nota do terceiro bimestre: ");
            aluno[i].ColocarNota3();
            Console.WriteLine("Digite a nota do quarto bimestre: ");
            aluno[i].ColocarNota4();
            Console.WriteLine("Digite a Turma em que ele está: ");
            aluno[i].turma = new Turma(id, Console.ReadLine());
            Console.WriteLine("Digite o nome do Curso em que ele está: ");
            aluno[i].curso = new Curso(id, Console.ReadLine());
            id++;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        int posicao = 1;
        for (int i = 0; i < aluno.Length; i++)
        {
            Console.WriteLine($"Selecione a operação do {posicao} aluno:");
            Console.WriteLine("1 - Calcular média do primeiro semestre e mostrar");
            Console.WriteLine("2 - Calcular média do segundo semestre e mostrar");
            Console.WriteLine("3 - Calcular média anual, mostra-la e dizer se está aporvado ou reprovado");
            Console.WriteLine("4 - Mostrar Relatório");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("A média semestral é: " +
                    aluno[i].CalcularMedia(aluno[i].notaBimestre1, aluno[i].notaBimestre2));
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;
                case 2:
                    Console.WriteLine("A média semestral é: " +
                    aluno[i].CalcularMedia(aluno[i].notaBimestre1, aluno[i].notaBimestre2));
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;
                case 3:
                    aluno[i].MostrarStatus();
                    Console.WriteLine(" ");
                    Console.WriteLine("");
                    break;
                case 4:
                    aluno[i].RelatorioAluno();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;
            }
        }
        for (int i = 0; i < aluno.Length; i++)
        {
            aluno[i].RelatorioAluno();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
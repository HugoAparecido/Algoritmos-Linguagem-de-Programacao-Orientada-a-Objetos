using System;
class Curso
{
    public int idCurso;
    public string? nomeCurso;
}
class Turma
{
    public int idTurma;
    public string? nomeTurma;
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
        return ((n1 + n2) / 4);
    }
    public double CalcularMedia(double n1, double n2, double n3, double n4)
    {
        return ((n1 + n2 + n3 + n4) / 4);
    }

}
class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("Digite respectivemente o prontuário do aluno e seu nome: ");
            Aluno aluno = new Aluno(Convert.ToInt32(Console.ReadLine()), nome: Console.ReadLine());
            Curso curso = new Curso();
            Turma turma = new Turma();
            aluno.turma = turma;
            aluno.curso = curso;
            aluno.turma.idTurma = i;
            aluno.curso.idCurso = i;
            Console.WriteLine("Digite o nome da Turma: ");
            aluno.turma.nomeTurma = Console.ReadLine();
            Console.WriteLine("Digite o nome do Curso: ");
            aluno.curso.nomeCurso = Console.ReadLine();
            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Calcular média semestral e mostrar");
            Console.WriteLine("2 - Calcular média anual, mostra-la e dizer se está aporvado ou reprovado");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Digite a nota do primeiro bimestre: ");
                    aluno.ColocarNota1();
                    Console.WriteLine("Digite a nota do segundo bimestre: ");
                    aluno.ColocarNota2();
                    Console.WriteLine("A média semestral é: " +
                    aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2));
                    break;
                case 2:
                    Console.WriteLine("Digite a nota do primeiro bimestre: ");
                    aluno.ColocarNota1();
                    Console.WriteLine("Digite a nota do segundo bimestre: ");
                    aluno.ColocarNota2();
                    Console.WriteLine("Digite a nota do terceiro bimestre: ");
                    aluno.ColocarNota1();
                    Console.WriteLine("Digite a nota do quarto bimestre: ");
                    aluno.ColocarNota2();
                    if (aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4) >= 6)
                    {
                        Console.WriteLine("Aluno Aprovado com a média " + aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4));
                    }
                    else if (aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4) < 6 && aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4) >= 3)
                    {
                        Console.WriteLine("Aluno em Recuperação com a média " + aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4));
                    }
                    else
                    {
                        Console.WriteLine("Aluno Reprovado com a média " + aluno.CalcularMedia(aluno.notaBimestre1, aluno.notaBimestre2, aluno.notaBimestre3, aluno.notaBimestre4));
                    }
                    break;
                default:
                    Console.WriteLine("Valor Inválidos");
                    break;
            }
        }
    }
}
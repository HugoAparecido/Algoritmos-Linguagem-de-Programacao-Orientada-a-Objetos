class Aluno
{
    public int id;
    public string[] nome = { "Everaldo", "João", "Ana", "Pedro", "Maria" };
    public double media;
    public Turma? turma;
    public Curso? curso;

    public double CalculaMedia(double n1, double n2, double n3, double n4)
    {
        return this.media = (n1 + n2 + n3 + n4) / 4;
    }
    public double CalculaMedia(double n1, double n2)
    {
        return this.media = (n1 + n2) / 2;
    }
}
class Curso
{
    public int codigoCurso;
    public string? nome;
    public string? periodo;
    public int cargaHoraria;
}
class Turma
{
    public int codigoTurma;
    public string? area;
    public int qtdAlunos;
}
class Program
{
    static void Main(string[] args)
    {
        //Instanciando as classes
        Aluno a = new();
        Curso c = new();
        Turma t = new();
        //Ligando os objetos
        a.curso = c;
        a.turma = t;
        Console.WriteLine(a.nome[0]);
        Console.WriteLine("Calculo da média");
        int opc = 1;
        switch (opc)
        {
            case 1:
                Console.WriteLine("Informe as notas do aluno");
                Console.WriteLine("Informe a primeira nota do aluno");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a segunda nota do aluno");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Media Semestral: " + a.CalculaMedia(nota1, nota2));
                break;
            case 2:
                Console.WriteLine("Informe a primeira nota do aluno");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a segunda nota do aluno");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a terceira nota do aluno");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quarta nota do aluno");
                double nota4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Media Anual: " + a.CalculaMedia(nota1, nota2, nota3, nota4));
                break;
        }
    }
}
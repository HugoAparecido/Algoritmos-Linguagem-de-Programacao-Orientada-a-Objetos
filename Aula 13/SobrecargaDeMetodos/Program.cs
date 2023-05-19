using System.Diagnostics;

class Conta
{
    //Atributos da classe Conta
    public double saldo;
    public double limite;
    public string? banco;
    public int agencia;
    public int numeroConta;
    public string? nomeTitular;
    //Métodos da classe Conta
    public void ImprimeExtrato()
    {
        this.banco = "Bradesco";
        this.agencia = 111;
        this.numeroConta = 12589001;
        this.nomeTitular = "Hugo Aparecido";
        this.limite = 5000.00;
        this.saldo = this.limite + 10000.00;
        Console.WriteLine("Saldo total da conta: R$" + this.saldo);
    }
    public void ImprimeExtrato(int dias)
    {
        this.banco = "Bradesco";
        this.agencia = 111;
        this.numeroConta = 12589001;
        this.nomeTitular = "Hugo Aparecido";
        this.limite = 5000.00;
        this.saldo = this.limite + 10000.00;
        for (int i = 0; i < dias; i++)
        {
            Console.WriteLine("Saldo total da conta: R$" + this.saldo);
        }
    }
}
class ProgramBanco
{
    static void Main(string[] args)
    {
        int opc, periodo;
        Conta conta = new();
        Console.WriteLine("Programa de Extratos do " + conta.banco);
        Console.WriteLine("Informe o tipo de extrato que deseja");
        Console.WriteLine("Digite 1 Extrato 15 dias");
        Console.WriteLine("Digite 2 Extrato por período");
        opc = Convert.ToInt32(Console.ReadLine());
        switch (opc)
        {
            case 1: conta.ImprimeExtrato(); break;
            case 2:
                Console.WriteLine("Informe o período");
                periodo = Convert.ToInt32(Console.ReadLine());
                conta.ImprimeExtrato(periodo); break;
        }
    }
}
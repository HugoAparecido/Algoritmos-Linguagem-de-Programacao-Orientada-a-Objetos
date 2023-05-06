using System;
class Conta
{
    //Atributos da classe conta
    public string? banco;
    public int numero;
    public int agencia;
    private double saldo; //Encapsulando o saldo da conta
    //public string Nomecliente;
    public Cliente? cliente; //Vinculando Cliente a Conta
    //Métodos da classe conta
    public void Sacar(double valor)
    {
        this.saldo -= valor;
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public void Extrato()
    {
        Console.WriteLine("R$ " + this.saldo);
    }
}
class Cliente
{
    //Atributos da classe Cliente
    public int cpf;
    public string? nome;
    public int telefone;
    public string? endereco;
    //Metodos da classe Cliente
    public void Cadastrar()
    {
        Console.WriteLine("Cadastro efetuado com sucesso!!");
    }
    public void Atualizar()
    {
        Console.WriteLine("Atualização efetuada");
    }
    public void Pesquisar()
    {
        Console.WriteLine("Pesquisa efetuada");
    }
    public void Remover()
    {
        Console.WriteLine("Removido com sucesso!!");
    }
    public void Bloquear()
    {
        Console.WriteLine("Bloqueio efetuado com sucesso!!");
    }
}
class Banco
{
    static void Main()
    {
        Conta conta = new Conta(); //Instanciando a classe Conta
        Cliente cli = new Cliente(); //Instanciando a classe Cliente
        conta.cliente = cli; //Vinculando os objetos
        conta.cliente.nome = "Everaldo Freitas";
        Console.WriteLine("Nome Cliente: " + conta.cliente.nome);
        conta.cliente.telefone = 1498877;
        Console.WriteLine("Telefone do Cliente: " + conta.cliente.telefone);
        conta.banco = "Banco do Brasil";
        Console.WriteLine("Banco do Cliente: " + conta.banco);
        //conta.saldo = 1000;
        conta.Depositar(1000);
        Console.Write("Valor do Saldo: ");
        conta.Extrato();
    }
}
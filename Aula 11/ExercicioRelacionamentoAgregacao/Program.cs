using System;
namespace ExercicioRelacionamentoAgragacao;
class Program
{
    class Cliente
    {
        //Atributos da Classe Cliente
        public int codigo = 1;
        public long rg;
        public string? nome;
        public string? email;
        //Métodos da Classe Cliente
        public void Cadastrar()
        {
            Console.Write("Digite seu nome: ");
            this.nome = Console.ReadLine();
            Console.Write("Digite seu RG: ");
            this.rg = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite seu e-mail: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Cadastro efetuado com sucesso!!");
        }
        public void Pesquisar()
        {
            Console.WriteLine("Pesquisa efetuada");
            Console.WriteLine("Código do cliente: " + this.codigo);
            Console.WriteLine("RG do Cliente: " + this.rg);
            Console.WriteLine("Nome do Cliente: " + this.nome);
            Console.WriteLine("E-mail do Cliente: " + this.email);
        }
        public void Atualizar()
        {
            Console.WriteLine("Digite seus dados antigos: ");
            Console.Write("Digite seu nome: ");
            this.nome = Console.ReadLine();
            Console.Write("Digite seu RG: ");
            this.rg = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite seu e-mail: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite os dados a serem atualizados (caso não haja modificação em alugum campo, digite-o igual a antes da modificação)");
            Console.Write("Digite seu nome: ");
            this.nome = Console.ReadLine();
            Console.Write("Digite seu RG: ");
            this.rg = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite seu e-mail: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Dados atualizados com sucesso!!");
        }
        public void Remover() 
        {
            this.codigo = 0;
            this.nome = "";
            this.email = "";
            this.rg = 0;
            Console.WriteLine("Clinte removido com sucesso!");
        }
    }
    class Hotel
    {
        //Atributos da Classe Hotel
        public int codigoReserva = 1;
        public string? nome;
        public string? tipoQuarto;
        public int numQuarto;
        public int dataEntrada;
        public int dataSaida;
        public Cliente? cliente;
        //Métodos da Classe Hotel
        public void reservar()
        {
            Console.Write("Digite o nome do hotel: ");
            this.nome = Console.ReadLine();
            Console.Write("Digite o tipo do quarto para estadia: ");
            this.tipoQuarto = Console.ReadLine();
            Console.Write("Digite o número do quarto para estadia: ");
            this.numQuarto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de entrada ao quarto: ");
            this.dataEntrada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de saída do quarto: ");
            this.dataSaida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reserva efetuada com sucesso!!");
        }
    }
    public static void Main(string[] args) 
    {
        Hotel hotel = new Hotel();
        Cliente cliente = new Cliente();
        hotel.cliente = cliente;
        hotel.cliente.Cadastrar();
        hotel.reservar();
        Console.WriteLine("O cliente " + hotel.cliente.nome + " que possui o RG" + hotel.cliente.rg + " e tem o e-mail: " + hotel.cliente.email + " fez a reserva do quarto número " + hotel.numQuarto + " do tipo " + hotel.tipoQuarto + " pertencente ao hotel " + hotel.nome + ", sendo que a data de sua estadia vai do dia " + hotel.dataEntrada + " até o dia " + hotel.dataSaida);
    }
}
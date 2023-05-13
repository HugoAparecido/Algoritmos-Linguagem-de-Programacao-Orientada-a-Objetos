using System;
namespace Exercicio3
{
    class Program
    {
        public struct Estrutura
        {
            public string? nomeMunicipio;
            public string? estado;
            public int populacao;
        };
        static void Main(string[] args)
        {
            Estrutura[] estrutura = new Estrutura[2];
            for (int i = 0; i < estrutura.Length; i++)
            {
                Console.Write("\nDigite o nome do município: ");
                estrutura[i].nomeMunicipio = Console.ReadLine();
                Console.Write("Digite o nome do estado ao qual o município pertence: ");
                estrutura[i].estado = Console.ReadLine();
                Console.Write("Digite o número de habitantes do município: ");
                estrutura[i].populacao = (int)Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine("Abaixo poderão estão listados todos os municípios do estado do Paraná: ");
            for (int i = 0;i < estrutura.Length;i++)
            {
                if (estrutura[i].estado == "Paraná" || estrutura[i].estado == "PR")
                    Console.WriteLine("Munícipio de " + estrutura[i].nomeMunicipio);
            }
            Estrutura maiorEstrutura = new()
            {
                populacao = 0
            };
            for (int i = 0; i < estrutura.Length; i++)
            {
                if (estrutura[i].populacao > maiorEstrutura.populacao)
                {
                    maiorEstrutura.nomeMunicipio = estrutura[i].nomeMunicipio;
                    maiorEstrutura.estado = estrutura[i].estado;
                    maiorEstrutura.populacao = estrutura[i].populacao;
                }
            }
            Console.WriteLine("O município com a maior população dentre os cdastrados anteriormente é " + maiorEstrutura.nomeMunicipio + ", possuindo " + maiorEstrutura.populacao + " habitantes e pertencendo ao estado de " + maiorEstrutura.estado);
        }
    }
}
using System;
namespace Exercicio2
{
    class Program
    {
        public struct Colmeia
        {
            public int codigo;
            public string? regiao;
            public string? estado;
            public string? qualificacao;
            public int numeroAbelhas;
        }
        static void Main(string[] args)
        {
            Colmeia[] colmeia = new Colmeia[10];
            for (int i = 0; i < colmeia.Length; i++)
            {
                Console.Write("\nDigite o código da colmeia: ");
                colmeia[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a região onde se encontra a colméia: ");
                colmeia[i].regiao = Console.ReadLine();
                Console.Write("Digite o estado onde se encontra a colméia: ");
                colmeia[i].estado = Console.ReadLine();
                Console.Write("Digite uma destas classificações exatamente como estão (forte, médio, fraco) conforme a capacidade de produção de mel: ");
                colmeia[i].qualificacao = Console.ReadLine();
                Console.Write("Digite o número de abelhas que habitam a colméia: ");
                colmeia[i].numeroAbelhas = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Desejas que mostre as colméias com qual dos três tipos de classificação (forte, médio, fraco) ?: ");
            string? classificacaoDesejada = Console.ReadLine();
            Console.WriteLine("Segundo o seu requerimento, foram encontadas as seguintes colméias: ");
            for (int i = 0; i < colmeia.Length; i++)
            {
                if (colmeia[i].qualificacao == classificacaoDesejada)
                    Console.WriteLine("Colméia código " + colmeia[i].codigo + " da região " + colmeia[i].regiao + " e do estado de " + colmeia[i].estado);
            }
        }
    }
}
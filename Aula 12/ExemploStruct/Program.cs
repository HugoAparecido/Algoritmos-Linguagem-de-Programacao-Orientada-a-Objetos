using System;
namespace Programa1
{
    class Program
    {
        // Estrutura produto
        public struct Produto
        {
            public int codigo;
            public string descricao;
        }
        static void Main(string[] args)
        {
            // Instnncia Produto
            Produto[] p = new Produto[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Informe o código do produto");
                p[x].codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a descrição do produto");
                p[x].descricao = Console.ReadLine();
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Código do produto: " + p[x].codigo);
                Console.WriteLine("Descrição do produto: " + p[x].descricao);
            }
        }
    }
}
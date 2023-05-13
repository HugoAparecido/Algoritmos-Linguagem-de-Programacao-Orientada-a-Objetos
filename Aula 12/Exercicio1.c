#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
int main(int argc, char *argv[])
{
    struct Candidata
    {
        int numeroInscricao;
        char nome[50];
        float altura;
        float peso;
        char naturalidade[50];
        string estado;
    } Candidata[] candidata = new Candidata[30];
    for (int i = 0; i < candidata.Length; i++)
    {
        Console.Write("Digite o número da candidata: ");
        candidata[i].numeroInscricao = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome da candidata: ");
        candidata[i].nome = Console.ReadLine();
        Console.Write("Digite a altura da candidata: ");
        candidata[i].altura = (float)Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o peso da candidata: ");
        candidata[i].peso = (float)Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a naturalidade da candidata: ");
        candidata[i].naturalidade = Console.ReadLine();
        Console.Write("Digite a sigla do estado da Candidata (exemplo: SP): ");
        candidata[i].estado = Console.ReadLine();
    }
    Console.WriteLine("As candidatas aprovadas foram: ");
    for (int i = 0; i < candidata.Length; i++)
    {
        if (candidata[i].estado == "SP" && candidata[i].altura > 1.85)
        {
            Console.WriteLine(candidata[i].nome);
        }
    }
}
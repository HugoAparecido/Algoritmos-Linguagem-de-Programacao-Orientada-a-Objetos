#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
int main()
{
    struct Candidata
    {
        int numeroInscricao;
        char nome[50];
        float altura;
        float peso;
        char naturalidade[50];
        char estado[2];
    };
    struct Candidata candidata[30];
    for (int i = 0; i < 30; i++)
    {
        printf("\nDigite o numero da candidata: ");
        scanf("%i", &candidata[i].numeroInscricao);
        printf("Digite o nome da candidata: ");
        scanf("%s", &candidata[i].nome);
        printf("Digite a altura da candidata: ");
        scanf("%f", &candidata[i].altura);
        printf("Digite o peso da candidata: ");
        scanf("%f", &candidata[i].peso);
        printf("Digite a naturalidade da candidata: ");
        scanf("%s", candidata[i].naturalidade);
        printf("Digite a sigla do estado da Candidata (exemplo: SP): ");
        scanf("%s", candidata[i].estado);
    }
    printf("\nAs candidatas aprovadas foram: ");
    for (int i = 0; i < 30; i++)
    {
        if (strcmp("SP", candidata[i].estado) == 0 && candidata[i].altura > 1.85)
        {
            printf("\n%s", candidata[i].nome);
        }
    }
}
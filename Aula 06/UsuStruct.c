#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main(int argc, char const *argv[])
{
    typedef struct
    {
        char nome[30];
        char rg[15];
        int idade;
        float saldo;
    } Cliente;
    Cliente cli;
    printf("Informe o nome do Cliente: ");
    gets(cli.nome);
    printf("Informe o RG do Cliente: ");
    gets(cli.rg);
    printf("Informe a idade do Cliente: ");
    scanf("%d", &cli.idade);
    printf("Informe o saldo do Cliente: ");
    scanf("%f", &cli.saldo);
    printf("Nome do cliente: %s\n", cli.nome);
    printf("RG do Cliente: %s\n", cli.rg);
    printf("Idade do Cliente: %d\n", cli.idade);
    printf("Saldo: %.2f\n", cli.saldo);
    // system("PAUSE");
    return 0;
}

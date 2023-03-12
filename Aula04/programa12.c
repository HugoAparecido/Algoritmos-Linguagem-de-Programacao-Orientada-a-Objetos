#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char nome[100], sobrenome[100];
    printf("Digite teu nome: ");
    scanf("%s", nome);
    printf("Digite teu sobrenome: ");
    scanf("%s", sobrenome);
    strcat(nome, sobrenome);
    printf("O nome digitado foi: %s", nome);
    return 0;
}
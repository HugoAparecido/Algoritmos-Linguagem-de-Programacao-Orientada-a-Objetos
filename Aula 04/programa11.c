#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char nome[100], auxiliar[100];
    printf("Digite teu nome: ");
    scanf("%s", nome);
    strcpy(auxiliar, nome);
    printf("O nome digitado foi: %s", auxiliar);
    return 0;
}
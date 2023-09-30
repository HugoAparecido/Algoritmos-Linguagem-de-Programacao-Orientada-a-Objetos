#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char nome[100];
    int quantidade;
    printf("Digite teu nome: ");
    scanf("%s", nome);
    quantidade = strlen(nome);
    printf("O tamanho do nome digitado foi de: %i caracteres", quantidade);
    return 0;
}
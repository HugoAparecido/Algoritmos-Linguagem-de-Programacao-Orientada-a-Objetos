#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char nome1[100], nome2[100], nome3[100];
    printf("Digite o primeiro nome: \n");
    scanf("%s", nome1);
    printf("Digite o segundo nome: \n");
    scanf("%s", nome2);
    printf("Digite o terceiro nome: \n");
    scanf("%s", nome3);
    // Palavra1 = Palavra2 -> 0
    // Palavra1 > Palavra2 -> (-)
    // Palavra1 < Palavra2 -> (+)
    if (strcmp(nome1, nome2) > 0)
    {
        char temp[50];
        strcpy(temp, nome1);
        strcpy(nome1, nome2);
        strcpy(nome2, temp);
    }
    if (strcmp(nome2, nome3) > 0)
    {
        char temp[50];
        strcpy(temp, nome2);
        strcpy(nome2, nome3);
        strcpy(nome3, temp);
    }
    if (strcmp(nome1, nome3) > 0)
    {
        char temp[50];
        strcpy(temp, nome1);
        strcpy(nome1, nome3);
        strcpy(nome3, temp);
    }
    printf("Nomes em ordem Alfabetica: %s, %s, %s,", nome1, nome2, nome3);
    return 0;
}
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    char palavra[100];
    int comprimento, i, palindromo = 1;
    printf("Digite uma palavra: ");
    scanf("%s", palavra);
    comprimento = strlen(palavra);
    for (i = 0; i < comprimento / 2; i++)
    {
        if (palavra[i] != palavra[comprimento - 1 - i])
        {
            palindromo = 0;
            break;
        }
    }
    if (palindromo)
    {
        printf("A palavra %s e um palindromo.", palavra);
    }
    else
    {
        printf("A palavra %s nao e um palindromo.", palavra);
    }
    return 0;
}
#include <stdio.h>
void main()
{
    int i = 0, maior, num, menor;
    while (i < 50)
    {
        i++;
        printf("Digite um numero: ");
        scanf("%i", &num);
        if (i == 1)
        {
            maior = num;
            menor = num;
        }
        if (num > maior)
        {
            maior = num;
        }
        if (num < menor)
        {
            menor = num;
        }
    }
    printf("O menor numero e: %i, e o maior e: %i", menor, maior);
}
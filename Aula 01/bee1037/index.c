#include <stdio.h>
int main()
{
    float numero;
    scanf("%f", &numero);
    if (numero < 0 || numero > 100)
    {
        printf("Fora de intervalo\n");
    }
    else
    {
        if (numero >= 0 && numero <= 25)
        {
            printf("Intervalo [0,25]\n");
        }
        else if (numero > 25 && numero <= 50)
        {
            printf("Intervalo (25,50]\n");
        }
        else if (numero > 50 && numero <= 75)
        {
            printf("Intervalo (50,75]\n");
        }
        else
        {
            printf("Intervalo (75,100]\n");
        }
    }
    return 0;
}
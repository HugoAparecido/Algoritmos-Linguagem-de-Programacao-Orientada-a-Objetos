#include <stdio.h>

int main()
{

    int al = 0, ga = 0, di = 0, fim = 0;
    while (fim != 4)
    {
        scanf("%i", &fim);
        if (fim == 1)
            al += 1;
        if (fim == 2)
            ga += 1;
        if (fim == 3)
            di += 1;
    }
    printf("MUITO OBRIGADO\n");
    printf("Alcool: %i\n", al);
    printf("Gasolina: %i\n", ga);
    printf("Diesel: %i\n", di);

    return 0;
}
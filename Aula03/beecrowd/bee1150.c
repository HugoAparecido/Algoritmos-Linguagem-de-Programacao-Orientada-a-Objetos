#include <stdio.h>

int main()
{

    int x = 0, z = 0, cont = 0, soma = 0;
    scanf("%i", &x);
    scanf("%i", &z);
    while (z <= x)
    {
        scanf("%i", &z);
    }
    while (soma < z)
    {
        soma += x;
        cont++;
        x++;
    }
    printf("%i\n", cont);

    return 0;
}
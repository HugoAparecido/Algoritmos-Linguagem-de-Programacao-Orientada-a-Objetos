#include <stdio.h>
#include <stdlib.h>

int main()
{

    int n, i;
    scanf("%i", &n);
    for (i = 1; i <= n * 4; i += 4)
    {
        printf("%i ", i);
        printf("%i ", i + 1);
        printf("%i ", i + 2);
        printf("PUM\n");
    }

    return 0;
}
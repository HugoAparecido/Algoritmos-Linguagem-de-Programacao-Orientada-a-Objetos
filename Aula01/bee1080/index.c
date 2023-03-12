#include <stdio.h>

int main()
{
    int n, max = -1, p, i;
    for (i = 1; i < 101; ++i)
    {
        scanf("%d", &n);
        if(max < n)
        max = n, p = i;
    }

    printf("%dn%dn", max, p);

    return 0;
}
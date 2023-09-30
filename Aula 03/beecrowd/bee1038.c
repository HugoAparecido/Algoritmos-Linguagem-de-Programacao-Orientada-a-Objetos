#include <stdio.h>
 
int main() {
 
    int codigo, quantidade;
    float preco = 0;
    scanf("%d %d", &codigo, &quantidade);
    if (codigo == 1)
    {
        preco = (float) (4.00 * quantidade);
    }
    else if (codigo == 2)
    {
        preco = (float) (4.50 * quantidade);
    }
    else if (codigo == 3)
    {
        preco = (float) (5.00 * quantidade);
    }
    else if (codigo == 4)
    {
        preco = (float) (2.00 * quantidade);
    }
    else if (codigo == 5)
    {
        preco = (float) (1.50 * quantidade);
    }
    printf("Total: R$ %.2f\n",preco);
    
 
    return 0;
}
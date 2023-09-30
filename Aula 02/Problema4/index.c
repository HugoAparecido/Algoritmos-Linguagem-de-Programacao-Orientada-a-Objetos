#include <stdio.h>
void main()
{
    float valorOriginalProduto, valorDesconto, valorAPagar;
    printf("Digite o valor do produto sem desconto: ");
    scanf("%f", &valorOriginalProduto);
    printf("Digite o valor do percentual de desconto: ");
    scanf("%f", &valorDesconto);
    if (valorOriginalProduto >= 0 && valorDesconto >= 0)
    {
        valorAPagar = valorOriginalProduto - (valorOriginalProduto * (valorDesconto / 100));
        printf("O valor a pagar do produto e: %.2f", valorAPagar);
    }
    else
    {
        printf("Nao ha valores negativos para o produto ou para o desconto!");
    }
}
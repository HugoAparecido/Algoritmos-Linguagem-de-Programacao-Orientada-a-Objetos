#include <stdio.h>
void main()
{
    float troco, valorCompra, valorPago;
    printf("Digite o valor da compra: ");
    scanf("%f", &valorCompra);
    printf("Digite o valor pago pelo cliente: ");
    scanf("%f", &valorPago);
    troco = valorPago - valorCompra;
    if (troco >= 0)
        printf("O valor do troco e: R$%.2f", troco);
    else
        printf("Valores invalidos, pois nao ha troco negativo!");
}
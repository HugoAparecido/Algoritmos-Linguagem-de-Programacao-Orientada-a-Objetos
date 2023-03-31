#include <stdio.h>

float troco(float oQuePagou, float oValorQueDeuaPagar)
{
    return oQuePagou - oValorQueDeuaPagar;
}
int main(void)
{
    float valorConsumido = 0, valorPago = 0;
    printf("Digite o valor que o cliente consumiu: ");
    scanf("%f", &valorConsumido);
    printf("\nDigite o valor pago pelo cliente: ");
    scanf("%f", &valorPago);
    if (troco(valorPago, valorConsumido) >= 0)
    {
        printf("\nO valor a ser dado de troco eh: RS%.2f", troco(valorPago, valorConsumido));
    }
    else
    {
        printf("\nO valor que o cliente deve eh: RS%.2f", (troco(valorPago, valorConsumido) * -1));
    }
    return 0;
}
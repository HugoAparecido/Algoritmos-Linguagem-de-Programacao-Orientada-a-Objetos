#include <stdio.h>

int main(void)
{
    float largura = 0, comprimento = 0, area = 0, valorMetro = 0, valorFinal;
    printf("Dgite o tamanho da largura do terreno em metros quadrados: ");
    scanf("%f", &largura);
    printf("\nDgite o tamanho do comprimento do terreno em metros quadrados: ");
    scanf("%f", &comprimento);
    printf("\nDgite o valor do metro quadrado em reais: ");
    scanf("%f", &valorMetro);
    area = comprimento * largura;
    valorFinal = area * valorMetro;
    printf("\nO valor de venda do imohvel serah: RS%.2f", valorFinal);
    return 0;
}
#include <stdio.h>

int main(void)
{
    float IMC = 0, peso = 0, altura = 0;
    printf("Digite teu peso em quilogramas: ");
    scanf("%f", &peso);
    printf("Digite tua altura em metros: ");
    scanf("%f", &altura);
    IMC = peso / (altura * altura);
    if (IMC <= 18.5)
    {
        printf("\nAbaixo do peso com o IMC de: %.2f", IMC);
    }
    else if (IMC <= 25.0)
    {
        printf("\nPeso ideal com o IMC de: %.2f", IMC);
    }
    else if (IMC <= 30.0)
    {
        printf("\nLevemnete acima do peso com o IMC de: %.2f", IMC);
    }
    else if (IMC <= 35.0)
    {
        printf("\nObesidade de grau I com o IMC de: %.2f", IMC);
    }
    else if (IMC <= 40.0)
    {
        printf("\nObesidade de grau II (severa) IMC de: %.2f", IMC);
    }
    else
    {
        printf("\nObesidade de grau III (mohrbida) IMC de: %.2f", IMC);
    }
    return 0;
}
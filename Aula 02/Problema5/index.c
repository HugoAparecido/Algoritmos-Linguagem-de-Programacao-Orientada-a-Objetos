#include <stdio.h>
void main()
{
    float fahrenheit, celsius;
    printf("Digite a temperatura em Fahranheit: ");
    scanf("%f", &fahrenheit);
    celsius = ((fahrenheit - 32) / 9) * 5;
    printf("A temperatura em Celsius e: %f", celsius);
}
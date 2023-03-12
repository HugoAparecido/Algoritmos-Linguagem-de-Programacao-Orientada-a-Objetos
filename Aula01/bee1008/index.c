#include <stdio.h>
int main()
{
    int numero, horasTrabalhadas;
    float valorPorHora, salario;
    scanf("%d %d %f", &numero, &horasTrabalhadas, &valorPorHora);
    salario = horasTrabalhadas * valorPorHora;
    printf("NUMBER = %d\n", numero);
    printf("SALARY = U$ %0.2f\n", salario);
    return 0;
}
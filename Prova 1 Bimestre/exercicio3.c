#include <stdio.h>

int main(void)
{
    double salario = 0, totalAtual = 0, totalAumento = 0, diferenca;
    int quantidadeDigitada = 0, quantidadeFuncionahrios = 0;
    printf("Digite a quantidade de funcionahrios na empresa: ");
    scanf("%i", &quantidadeFuncionahrios);
    while (quantidadeDigitada < quantidadeFuncionahrios)
    {
        quantidadeDigitada++;
        printf("\nDigite o salahrio atual do funcinahrio: ");
        scanf("%lf", &salario);
        if (salario >= 0)
        {
            totalAtual += salario;
            if (salario <= 400.00)
            {
                totalAumento += (salario + (salario * 0.15));
            }
            else if (salario <= 800.00)
            {
                totalAumento += (salario + (salario * 0.12));
            }
            else if (salario <= 1200.00)
            {
                totalAumento += (salario + (salario * 0.1));
            }
            else if (salario <= 2000.00)
            {
                totalAumento += (salario + (salario * 0.07));
            }
            else
            {
                totalAumento += (salario + (salario * 0.12));
            }
        }
        else
        {
            printf("\nSalahrio invalido");
        }
    }
    diferenca = totalAumento - totalAtual;
    printf("\nO valor total pago atualmente eh: %lf\nO valor total a pagar apohs o aumento serah: %lf\nA diferenca entre o valores eh de: %lf", totalAtual, totalAumento, diferenca);
    return 0;
}
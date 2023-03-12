#include <stdio.h>
void main()
{
    float nota1, nota2, media, totalAulas, totalPercentualPresenca, aulasAssitidadasAluno;
    printf("Digite a primeira nota: ");
    scanf("%f", &nota1);
    printf("Digite a segunda nota: ");
    scanf("%f", &nota2);
    printf("Digite o toatal de aulas lecionadas: ");
    scanf("%i", &totalAulas);
    printf("Digite o toatal de presencas do aluno: ");
    scanf("%i", &aulasAssitidadasAluno);
    if (nota1 > 10 || nota1 < 0 || nota2 > 10 || nota2 < 0 || aulasAssitidadasAluno > totalAulas)
    {
        printf("Valor(es) invalidos");
    }
    else
    {
        media = (nota1 + nota2) / 2;
        totalPercentualPresenca = aulasAssitidadasAluno / totalAulas * 100;
        if (media >= 6 && totalPercentualPresenca >= 75)
        {
            printf("Aluno aprovado");
        }
        else
        {
            printf("Aluno Reprovado");
        }
    }
}
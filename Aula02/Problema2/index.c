#include <stdio.h>
void main()
{
    float prova1, prova2, prova3, media;
    printf("Digite a nota da primeira prova: ");
    scanf("%f", &prova1);
    printf("Digite a nota da segunda prova: ");
    scanf("%f", &prova2);
    printf("Digite a nota da terceira prova: ");
    scanf("%f", &prova3);
    if (prova1 >= 0 && prova2 >= 0 && prova3 >= 0 && prova1 <= 10 && prova2 <= 10 && prova3 <= 10)
    {
        media = (prova1 + prova2 + prova3) / 3;
        printf("A media na disciplina do professo Robson neste caso e: %.2f", media);
    }
    else if (prova1 <= 0 || prova2 <= 0 || prova3 <= 0)
        printf("O valor de alguma nota foi digitado errado, pois nao ha notas negativas!");
    else
        printf("Nao e permitido notas de provas maiores que 10");
}
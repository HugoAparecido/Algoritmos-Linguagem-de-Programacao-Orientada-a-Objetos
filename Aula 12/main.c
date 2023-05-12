#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
int main(int argc, char *argv[])
{
    struct fichaAluno
    {
        char nome[50];
        char disciplina[30];
        float nota_prova1;
        float nota_prova2;
    };
    struct fichaAluno Aluno;
    printf("Informe o nome do aluno: ");
    gets(Aluno.nome);
    printf("Informe a disciplina do aluno: ");
    gets(Aluno.disciplina);
    Aluno.nota_prova1 = 10;
    Aluno.nota_prova2 = 8;
    printf("Nome do aluno: %s\n", Aluno.nome);
    printf("Disciplina aluno: %s\n", Aluno.disciplina);
    printf("Nota 1 do aluno: %0.2f\n", Aluno.nota_prova1);
    printf("Nota 2 do aluno: %0.2f\n", Aluno.nota_prova2);
    return 0;
}
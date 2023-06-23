#include <stdio.h>
#include <string.h>

int main(void)
{
    char senha[20], i = 0;
    printf("Digite a palavra a ser transformada em senha (ela nao pode ter espaco): ");
    scanf("%s", senha);
    while (i < strlen(senha))
    {
        if (senha[i] == 'a' || senha[i] == 'A')
        {
            senha[i] = '@';
        }
        if (senha[i] == 'o' || senha[i] == 'O')
        {
            senha[i] = '0';
        }
        if (senha[i] == 'i' || senha[i] == 'I')
        {
            senha[i] = '1';
        }
        if (senha[i] == 's' || senha[i] == 'S')
        {
            senha[i] = '5';
        }
        if (senha[i] == 'e' || senha[i] == 'E')
        {
            senha[i] = '3';
        }
        i++;
    }
    if (strlen(senha) < 8)
    {
        printf("\nA senha serah insegura");
    }
    printf("\nA palavra ficarah da seguinte forma: %s", senha);
    return 0;
}
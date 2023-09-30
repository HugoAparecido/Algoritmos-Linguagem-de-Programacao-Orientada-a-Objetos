#include <iostream>
using namespace std;
void imprimirQuadrado(int N)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            cout << "*";
        }
        cout << endl;
    }
}
int main(void)
{
    int numero;
    cout << "Digite um numero entre 1 e 100: ";
    cin >> numero;
    if (numero > 0 && numero <= 100)
    {
        imprimirQuadrado(numero);
    }
    else
    {
        cout << "Valor fora do esperado";
    }
    return 0;
}
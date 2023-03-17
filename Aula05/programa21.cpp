#include <iostream>
using namespace std;
float valorPosAumento(float salAtual)
{
    if (salAtual <= 2000)
    {
        return salAtual + salAtual * (20.0 / 100.0);
    }
    else
    {
        return (salAtual + (salAtual * (10.0 / 100.0)));
    }
}
int main(void)
{
    float salario, nsal;
    cout << "Digite o salahrio do funcionahrio xxx: ";
    cin >> salario;
    if (salario >= 0)
    {
        cout << "O valor do salahrio do funcinahrio apohs aumento eh: " << valorPosAumento(salario);
    }
    else
    {
        cout << "Valor nao aceito, pois ele eh negativo";
    }
    return 0;
}
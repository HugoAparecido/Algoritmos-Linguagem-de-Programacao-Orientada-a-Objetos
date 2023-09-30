#include <bits/stdc++.h>
using namespace std;
int testeNaoFormaTriangulo(float num1, float num2, float num3)
{
    return num1 >= (num2 + num3) || num2 >= (num1 + num3) || num3 >= (num1 + num2);
}
int testeTrianguloRetangulo(float num1, float num2, float num3)
{
    return num1 * num1 == (num2 * num2 + num3 * num3) || num2 * num2 == (num1 * num1 + num3 * num3) || num3 * num3 == (num1 * num1 + num2 * num2);
}
int testeTrianguloObtusangulo(float num1, float num2, float num3)
{
    return num1 * num1 > (num2 * num2 + num3 * num3) || num2 * num2 > (num1 * num1 + num3 * num3) || num3 * num3 > (num1 * num1 + num2 * num2);
}
int testeTrianguloAcutangulo(float num1, float num2, float num3)
{
    return num1 * num1 < (num2 * num2 + num3 * num3) || num2 * num2 < (num1 * num1 + num3 * num3) || num3 * num3 < (num1 * num1 + num2 * num2);
}
int testeTrianguloEquilatero(float num1, float num2, float num3)
{
    return num1 == num2 && num1 == num3;
}
int testeTrianguloIsosceles(float num1, float num2, float num3)
{
    return (num1 == num2 && num1 != num3) || (num1 == num3 && num1 != num2) || (num2 == num3 && num2 != num1);
}
int main()
{
    double a, b, c;

    cin >> a >> b >> c;

    if (testeNaoFormaTriangulo(a, b, c))
        cout << "NAO FORMA TRIANGULO" << endl;
    else if (testeTrianguloRetangulo(a, b, c))
        cout << "TRIANGULO RETANGULO" << endl;
    else if (testeTrianguloObtusangulo(a, b, c))
        cout << "TRIANGULO OBTUSANGULO" << endl;
    else if (testeTrianguloAcutangulo(a, b, c))
        cout << "TRIANGULO ACUTANGULO" << endl;
    if (testeTrianguloEquilatero(a, b, c))
        cout << "TRIANGULO EQUILATERO" << endl;
    if (testeTrianguloIsosceles(a, b, c))
        cout << "TRIANGULO ISOSCELES" << endl;

    return 0;
}
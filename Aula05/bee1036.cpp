#include <iostream>
#include <cmath>
using namespace std;
float delta(float num1, float num2, float num3)
{
    return num2 * num2 - 4.0 * num1 * num3;
}
float bhaskaraAdicao(float num1, float num2, float delt)
{
    return (-num2 + sqrt(delt)) / (2.0 * num1);
}
float bhaskarasubtracao(float num1, float num2, float delt)
{
    return (-num2 - sqrt(delt)) / (2.0 * num1);
}
int main()
{

    float A, B, C, delta;
    cin >> A;
    cin >> B;
    cin >> C;
    if (A != 0 && delta(A, B, C)<=0)

        return 0;
}
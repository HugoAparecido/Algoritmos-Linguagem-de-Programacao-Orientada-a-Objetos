#include <stdio.h>
#include <math.h>
float calculoDelta(float A, float B, float C)
{
    return (B * B) - 4.0 * A * C;
}
float bhaskaraPositivo(float num1, float num2, float num3)
{
    return ((-num2 + sqrt(calculoDelta(num1, num2, num3))) / (2 * num1));
}
float bhaskaraNegativo(float num1, float num2, float num3)
{
    return ((-num2 - sqrt(calculoDelta(num1, num2, num3))) / (2 * num1));
}
int main()
{
    double a, b, c;
    scanf("%lf %lf %lf", &a, &b, &c);

    if (calculoDelta(a, b, c) < 0 || a == 0)
    {
        printf("Impossivel calcular\n");
    }
    else
    {
        printf("R1 = %.5lf\nR2 = %.5lf\n", bhaskaraPositivo(a, b, c), bhaskaraNegativo(a, b, c));
    }
    return 0;
}
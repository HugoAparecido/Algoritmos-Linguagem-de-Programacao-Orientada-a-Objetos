#include <stdio.h>
int main()
{
    float A, B, C, areaTraphisium, perimeterTriangle ;

    scanf("%f %f %f", &A, &B, &C);

    if ((A < (float)(B+C)) && (B < (float)(A+C)) && (C < (float)(B+A)))
    {
        perimeterTriangle = A + B + C;
        printf("Perimetro = %.1fn",perimeterTriangle);
    }
    else
    {
        areaTraphisium = ((A + B) * C) / 2;
        printf("Area = %.1fn",areaTraphisium);
    }
    return 0;
}
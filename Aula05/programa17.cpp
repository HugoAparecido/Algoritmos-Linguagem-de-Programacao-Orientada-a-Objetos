#include <iostream>
using namespace std;
void imprimeLinha(int n)
{
    int x;
    for (x = 0; x < n; x++)
    {
        cout << "=";
    }
    cout << endl;
}
int main(void)
{
    imprimeLinha(10);
    cout << "Seu nome" << endl;
    imprimeLinha(10);
    cout << "Instituto Federal" << endl;
    imprimeLinha(20);
    return 0;
}
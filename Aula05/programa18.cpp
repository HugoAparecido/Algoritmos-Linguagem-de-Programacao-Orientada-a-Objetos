#include <iostream>
using namespace std;
int dobro(int n)
{
    return n * 2;
}
int main(void)
{
    int num;
    cout << "Digite um numero: ";
    cin >> num;
    cout << "O dobro de " << num << " eh " << dobro(num) << endl;
    return 0;
}
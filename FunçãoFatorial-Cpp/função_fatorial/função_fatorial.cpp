// função_fatorial.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

int fatorial = 0;
int resultado = 0;

int fatorresultado(int);

int main()
{
	cout << "Digite um fatorial:  ";
	cin >> fatorial;

	resultado = fatorresultado(fatorial);
	cout << "\n O resultado é:  "<<resultado;
}
int fatorresultado(int fator)
{
	int r = 1;
	for (int cal = fator; cal >= 1; cal--)
	{
		r = r * cal;
	}
	return r;
}

// calcularNotas.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

//definindo variavéis:
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double media = 0;

//inicio do código:
int main()
{
	cout << "Informe nota 1:  ";
	cin >> nota1;
	cout << "Informe nota 2:  ";
	cin >> nota2;
	cout << "Informe nota 3:  ";
	cin >> nota3;

	//calculo da média:
	media = (nota1 + nota2 + nota3) / 3;
	cout << "\nmédia é:  " << media;


	if (media >= 0 && media < 5)
	{
		cout << "\nReprovado";
	}
	else if (media >= 5 && media < 7)
	{
		cout << "\nExame";
	}
	else {
		media >= 7;
		cout << "\nAprovado";
	} return (0);
}

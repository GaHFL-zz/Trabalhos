// ImpaPar.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.


#include <iostream>
using namespace std;

	//Definindo variáveis

	int num = 0;
	int somaP = 0;
	int somaI = 0;

int main()
{
//Iniciando o código
	
		cout << "Digite um número:  ";
		cin >> num;

		for (int contador = 1; contador <= num; contador++)
		{
			if (contador % 2 == 0) {
				somaP = somaP + contador;
			}
			else {
				somaI = somaI + contador;
			}
		}
		cout << "\nA Soma de Pares é: " << somaP;
		cout << "\nA Soma de impares é: " << somaI;

		getchar();
			system("C|S");
		return(0);

	}
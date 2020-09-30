#include <iostream>
#include <stdlib.h>
using namespace std;

struct Dados {
	int numero;
};

void coletadados(int qtde, Dados al[]);
void ordenadados(int qtde, Dados al[]);
void exibedados(int qtde, Dados al[]);
void exibeedados(int qtde, Dados al[]);

int main() {
	int qtde = 0;
	cout << "Digite quantidade de numeros: ";
	cin >> qtde;
	Dados* al = new Dados[qtde];
	coletadados(qtde, al);
	ordenadados(qtde, al);
	system("cls");
	exibedados(qtde, al);
	exibeedados(qtde, al);
	delete[] al;
}

void coletadados(int qtde, Dados al[]) {
	for (int i = 0; i < qtde; i++) {
		fflush(stdin);
		cout << "\nDigite o numero:  ";
		cin >> al[i].numero;
		cout << endl;
	}
}

void ordenadados(int qtde, Dados al[]) {
	int aux = 0;
	for (int i = 0; i < qtde; i++) {
		for (int j = i; j < qtde; j++) {
			if (al[i].numero > al[j].numero) {
				aux = al[i].numero;
				al[i].numero = al[j].numero;
				al[j].numero = aux;
			}
		}
	}
}

void exibedados(int qtde, Dados al[])
{
	for (int i = 0; i < qtde; i++) {
		cout << "***************";
		cout << "\nNumeros: " << al[i].numero;
		cout << "\n***************";
		cout << endl;
	}
}
void exibeedados(int qtde, Dados al[])
{
	cout << "***************";
	cout << "\nNumero menor: " << al[0].numero;
	cout << "\nNumero maior: " << al[qtde - 1].numero;
	cout << "\n***************";
	cout << endl;
}
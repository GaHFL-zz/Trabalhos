#include <iostream>
#include <locale.h>
#include <stdlib.h>
using namespace std;

int v;


int main() 
{
	setlocale(LC_ALL, "portuguese");
	
	cout << " \nInforme a quantidade letras: "	;
	cin>> v;
	cout << "\n Digite um nome: ";
	char *name;
	name =(char*)malloc(v*sizeof(char));//para fazer um array do tamanho da palavra, sem sobrar ou faltar
	cin >> name;
	cout << "\n Tamanho do nome é: " << sizeof(name);
	free(name);
	
	return 0;
}

/* porque retorna 8? porque um ponteiro tem 8 bytes de memoria.*/


#include <iostream>
#include <locale.h>
using namespace std;

int v;


int main() 
{
	setlocale(LC_ALL, "portuguese");
	
	cout << " \nInforme a quantidade: "	;
	cin>> v;
	cout << "\n Digite um nome: ";
	char name [v]; // nessa posição devia dar erro.
	cin >> name;
	cout <<"\n Tamanho de v é: " << sizeof(v);
	cout << "\n Tamanho do array: " << sizeof(name);
	cout << " \n" << name;
	return 0;
}


/*malloc - memory alocation- esse comando retorna um ponteiro do tipo void
a memoria do tipo int separa 4 bits para receber a variável.

*/


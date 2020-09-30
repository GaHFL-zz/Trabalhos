#include <iostream>
#include<queue> //necessário para usar fila no sistema.
#include<locale.h>
using namespace std;


int main()
{
	setlocale(LC_ALL, "portuguese");

	//queue(fila)<o tipo de dado> nome--- é a forma de como chama uma fila
	queue<string> fila;

	//como colocar algo na fila
	fila.push("Palmeiras não tem mundial");
	fila.push("Silêncio na favela");

	//saber o tamanho da fila, ou quantidade do que está guardado

	cout << "\no tamanho da fila é: " << fila.size() << "\n";

	//mostrar o que está a frente da fila
	cout << "\nA frente da fila contém: " << fila.front() << "\n";

	//comando para mostrar o que está atrás na fila
	cout << "\nO fundo a fila contém: " << fila.back() << "\n";

	//comando para tirar o que está a frnete, OU RETIRAR O QUE ESTÁ NA fila
	fila.pop();

	cout << "\no tamanho da fila é: " << fila.size() << "\n";
	cout << "\nA frente da fila contém: " << fila.front() << "\n";
	cout << "\nO fundo a fila contém: " << fila.back() << "\n";

	//comando para esvaziar a fila
	while (!fila.empty())
	{
		fila.pop();
	}


	cout << "\no tamanho da fila é: " << fila.size() << "\n";
	cout << "\nA frente da fila contém: " << fila.front() << "\n";
	cout << "\nO fundo a fila contém: " << fila.back() << "\n";


	/*A FILA TEM UMA ENTRADA E UMA SAÍDA DISTINTAS.
	*/
	return 0;
}

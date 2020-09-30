#include <iostream>
#include<stack> //necessário para usar pilha no sistema.
#include<locale.h>
using namespace std;


int main()
{
	setlocale(LC_ALL, "portuguese");
	//stack(pilha)<o tipo de dado> nome--- é a forma de como chama uma pilha
	stack<string> pilha;

	//como colocar algo na pilha
	pilha.push("Palmeiras não tem mundial");
	pilha.push("Silêncio na favela");

	//saber o tamanho da pilha, ou quantidade do que está guardado

	cout << "\no tamanho da pilha é: " << pilha.size() << "\n";

	//mostrar o que está no topo da pilha
	cout << "\no topo da pilha contém: " << pilha.top() << "\n";

	//comando para tirar o que está no topo, OU RETIRAR O QUE ESTÁ NA PILHA
	pilha.pop();

	cout << "\no tamanho da pilha é: " << pilha.size() << "\n";
	cout << "\no topo da pilha contém: " << pilha.top() << "\n";

	//comando para esvaziar a pilha
	while (!pilha.empty())
	{
		pilha.pop();
	}

	cout << "\no tamanho da pilha é: " << pilha.size() << "\n";
	cout << "\no topo da pilha contém: " << pilha.top() << "\n";


	/*NÃO TEM COMO ESVAZIAR A PILHA DE UMA VEZ,
	TEM QUE SER UM POR UM.
	*/
	return 0;
}

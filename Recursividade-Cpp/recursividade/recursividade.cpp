// recursividade.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//
//bibliotecas usadas
#include <iostream>
using namespace std;

//variáveis usadas
int fatorial = 0;
int res = 0;

//chamada de função
int fatorialresultado(int);

//início do código
int main()
{
	cout << "Digite um número: ";
	cin >> fatorial;

	//chamando a função definida para efetuar o calculo:
	res = fatorialresultado(fatorial);

	cout << "\nO resultado é:  " << res;

}
//formatando a função para a execução
int fatorialresultado(int fator)
{
	//recursividade dentro da função
	if (fator <= 1){
		return 1;
	}
	else {
		return fator * fatorialresultado(fator - 1);
	}
	system("cls");
}
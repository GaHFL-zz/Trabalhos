// calculadora.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//
//bibliotecas utilizadas
#include <iostream>
using namespace std;

//variáveis
int n1 = 0;
int n2 = 0;
int operacao = 0;
int soma = 0;
int sub = 0;
int multi = 0;
int divisao = 0;


//iniciando o programa
int main()
{
	cout << "\n Digite um numero:  ";
	cin >> n1;
	cout << "\n Digite outro numero:  ";
	cin >> n2;
	cout << "\n Escolha uma operação: 1-Soma; 2-Subtração; 3-Multiplicação; 4-Divisão:  ";
	cin >> operacao;

	switch (operacao)//escolha da operação
	{
	case 1://operação de soma
		soma = n1 + n2;
			cout << "\nA soma é:  " << soma;
		break;
	case 2://operação de subtração
		sub = n1 - n2;
			cout << "\nA subtração é:  " << sub;
		break;
	case 3://operação de multiplicação
		multi = n1 * n2;
			cout << "\nA multiplicação é:  " << multi;
		break;
	case 4://operação de divisão
		if (n2 == 0)//caso o n2 for zero, não existe divisão por zero.
		{
			cout << "Impossível dividir por 0";
		}//continuando, caso n2 não for zero...
		else {
			divisao = n1 / n2;
				cout << "\nA divisão é:  " << divisao;
		}
		break;
	}
	return 0;
}
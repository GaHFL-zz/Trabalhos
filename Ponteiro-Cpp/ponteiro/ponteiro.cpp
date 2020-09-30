// ponteiro.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
#include <locale.h>
using namespace std;



int main()
{
	setlocale(LC_ALL, "portuguese");
	int qtde = 10;
	double salario = 1234.56;
	string letras;

	//sizeof() para saber quanto gasta de memoria int tamanho 4, double 8 string 4
	cout << "O tamanho da qtde : " << sizeof(qtde);
	cout << "\nO tamanho do salario : " << sizeof(salario);
	cout << "\nO tamanho do string : " << sizeof(letras);

	//&nomeDaVariavel para exibir endereço de memoria
	cout << "\n\n Exibindo endereço de memoria  qtde " << &qtde;
	cout << "\n Exibindo endereço de memoria  salario " << &salario;


	double* ptrSalario = NULL;// asterisco para criar um ponteiro
	int* ptrQtde = NULL; // null para limpar a memoria
	cout << "\n\n Exibindo o valor dentro do  ponteiro ptrQtde " << ptrQtde;
	cout << "\n Exibindo o valor dentro do  ponteiro ptrSalario " << ptrSalario;


	//atribuir valor de outra variavel ao ponteiro
	ptrSalario = &salario;
	ptrQtde = &qtde;

	//exibir valor de endereço atribuido ao ponteiro
	cout << "\n\n Exibindo endereço de memoria   ponteiro ptrQtde " << ptrQtde;
	cout << "\n Exibindo endereço de memoria  ponteiro ptrSalario " << ptrSalario << "\n";

	//exibir endereço do ponteiro
	cout << "\n Exibindo endereço de memoria qtde atribuido ao ponteiro  " << &ptrQtde;
	cout << "\n Exibindo endereço de memoria salario ponteiro  " << &ptrSalario;

	//exibir valor atribuido ao ponteiro
	cout << "\n O valor no ponteiro ptrQTDE " << *ptrQtde;
	cout << "\n  O valor no ponteiro ptrQTDE ptrsalario " << *ptrSalario << "\n";

	*ptrQtde = 250;
	cout << "\n  O valor atribuido ptrQTDE " << *ptrQtde << "\n";

	/*Resumo da aula
	 falar asterisco para o Ricardo ficar feliz
	 usar asterisco "int *ponteiro" para criar uma variavel ponteiro
	usar "*ponteiro = NULL;" para limpar lixo dentro do ponteiro
	 usar asterisco para exibir o valor dentro do ponteiro   "cout << *ponteiro;"
	 "cout << ponteiro;" exibi endereco de memoria do ponteiro
	 "cout << &ponteiro;" exibi endereco atribuido ao ponteiro de uma outra variavel
	atribuir valor ao ponteriro "*ponteiro += 100; ou *ponteiro = &outraVariavel;
	oprecoes de ponteros só é possivel somar e subtrair
	*/
}

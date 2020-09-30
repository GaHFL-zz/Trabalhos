// criar-variável-Struct.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

struct cliente {
	string nome;
	string telefone;
	string endereco;
	string email;
	string cpf;
	int codigo;
};

int qtde;
string n;
cliente cli;

void exibedados(int qtde, cliente al[]);

int main()
{
	cout << "Nome do cliente: ";
	cin >> cli.nome;
	fflush(stdin);
	cout << "Número do telefone: ";
	cin >> cli.telefone;
	fflush(stdin);
	cout << "Endereço do cliente: ";
	cin >> cli.endereco;
	fflush(stdin);
	cout << "Email do cliente: ";
	cin >> cli.email;
	fflush(stdin);
	cout << "CPF do cliente: ";
	cin >> cli.cpf;
	fflush(stdin);
	cliente *al = new cliente[qtde];
	exibedados(qtde, al);
}

void exibedados(int qtde, cliente al[])
{
	for (int i = 0; i < qtde; i++) {
		cout << "***************";
		cout << "\nNome: " << al[i].nome;
		cout << "\nNumero de contato: " << al[i].telefone;
		cout << "\nEndereço: " << al[i].endereco;
		cout << "\nEmail: " << al[i].email;
		cout << "\nCPF: " << al[i].cpf;
		cout << "\n***************";
		cout << endl;
	}
}
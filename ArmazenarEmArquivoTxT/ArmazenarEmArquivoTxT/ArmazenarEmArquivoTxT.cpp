#include <iostream>
#include<fstream>
#include<string>
using namespace std;

fstream arquivo;
char continuar;
string nome;

int main()
{
	//criar arquivo de atualização
	arquivo.open("exemplo.txt", ios::out | ios::app);

	do {
		cout << "\nDigite um nome: ";
		cin >> nome;


		//gravar algo no arquivo
		arquivo << nome << "\n";
		cout << "Continua(S/N)?  ";
		cin >> continuar;
	} while (continuar == 's' || continuar == 'S');
	arquivo.close();

	//leitura do arquivo
	arquivo.open("exemplo.txt", ios::in);
	cout << "conteudo do arquivo\n";

	if (arquivo.is_open())
	{
		string linha;
		while (getline(arquivo, linha))
		{
			cout << linha << "\n";
		}
		arquivo.close();
	}

	return 0;
}

/* há tres formas de trabalhar.
ler
atualizar
inserir
*/
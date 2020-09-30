#include <iostream>
#include <list>
using namespace std;

//para criar uma "List<int> notas"
list<int> notas;
int n;
char continuar;

int main()
{
	//comando "do" quando se repete apenas uma vez.
	do {
		cout << "\n Digite uma nota: ";

		cin >> n;

		//comando para inserir no fundo da lista "(nome).push_back(var)", ou "(nome).push_front(var)" para inserir no começo
		notas.push_back(n);

		cout << "\nDeseja continuar(s/n)?";
		cin >> continuar;
	} while (continuar == 's' || continuar == 'S');

	//comando'iterator' para criar um ponteiro na lista
	list<int>::iterator it;
	it = notas.begin();
	cout << "\n";
	cout << "****" << "\n";
	for (it = notas.begin(); it != notas.end(); ++it)	//++ na frente soma antes de fazer as coisas
	{
		cout << *it << "\n";

	}

	//comando para inserir algo no meio
	it = notas.begin();
	advance(it, 2);
	notas.insert(it, 333);

	cout << "****" << "\n";

	int t = notas.size();
	for (int i = 0; i < t; i++) {
		//mostrar o último	
		cout << notas.back() << "\n";

		//comando para remover as notas
		notas.pop_back();

	}
	return 0;
}

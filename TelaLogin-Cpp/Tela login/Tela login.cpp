// Tela login.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
#include <locale.h>

using namespace std;

char usuario[10] = "gabriel";
char usuario1[10];
char senha[5] = "1234";
char senha1[5];
int i = 0;

int main()
{
	setlocale(LC_ALL, "Portuguese");
	cout << "\nUsuário:  ";
	cin >> usuario1;
	cout << "\nSenha: ";
	cin >> senha1;
	
	if (strcmp(usuario, usuario1) == 0)
	{
		cout << "\nLogin com sucesso\n";
	}
	else{
		cout << "\nFalha no Login\n";
		cout << "\Verifique se a senha e usuários estão corretos.\n";

	}

	system("PAUSE");
	return 0;

}

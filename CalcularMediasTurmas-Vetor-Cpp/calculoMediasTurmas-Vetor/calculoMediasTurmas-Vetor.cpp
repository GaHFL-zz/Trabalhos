// calculoMediasTurmas-Vetor.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

int qtdeAlunos = 0;
int qtdeTurmas = 0;

float mediasTurmas[1000];

int main()
{
	cout << "Informe a quantidade de turmas: ";
	cin >> qtdeTurmas;
	cout << "Informe a quantidade de Alunos: ";
	cin >> qtdeAlunos;

	for (int i = 0; i <= qtdeTurmas - 1; i++) {
		int aprovados = 0;
		for (int j = 0; j <= qtdeAlunos; j++) {
			cout << "\nDigite a nota do aluno: ";
			float nota = 0;
			cin >> nota;
			if (nota >= 5) {
				aprovados++;
			}
		}
		mediasTurmas[i] = ((float)aprovados) / qtdeAlunos;
	}

	for (int k = 0; k <= qtdeTurmas; k++) {
		cout << "\nA média da aprovação da turma:  " << k << "foi de " << mediasTurmas[k];
	}
}

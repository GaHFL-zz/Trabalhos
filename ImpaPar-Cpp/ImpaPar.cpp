//ImparPar

#include <iostream>
using namespace std;

//Definindo vari�veis

int num = 0;
int somaP = 0;
int somaI = 0;

//Iniciando o c�digo

int main()
{
	cout<<"Digite um n�mero:  ";
	cin>> num;
	 
	 for (int contador = 1; contador <= num; contador++)
	 {
		if (contador%2==0){
			somaP = somaP + contador;
		} else{
			somaI = somaI + contador;
		}
	}
		cout<<"\nA Soma de Pares �: " << somaP;
		cout<<"\nA Soma de impares �: " << somaI;
}	

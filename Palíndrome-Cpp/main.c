#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL,"portuguese");
	char texto[100], inverso[100];
	int i, f;

	printf("\nDigite uma frase:  ");
	gets(texto);
	strlen(texto);
	
	f = 0;

	for (i = strlen(texto) - 1; i >= 0; i--) {
		inverso[f] = texto[i];
		f++;
	}
	inverso[f] = '\0';
	printf("\nA frase inversa é:  %s\n", inverso);

	if (strcmp(texto, inverso) == 0) {
		printf ("\n\nÉ palíndromo!");
	}
	else {
		printf("\nNão é palíndromo!");
		
		system("pause");
	}
	
	return 0;
}

using System;

namespace RelaçãoEntreClasses
{
     //definindo um classe para "convidados".
    public class Convidados
    {
        public int Total(int noivo, int noiva)
        {
            return noivo + noiva;
        }
        public int TotalPresentes(int convidadosNoivo, int convidadosNoiva)
        {
            return convidadosNoivo + convidadosNoiva;
        }

    }
    public class Program
    {
        public static void Main()
        {
            //Definindo as varíaveis.
            int convidadosNoivo;
            int noivo;
            int convidadosNoiva;
            int noiva;

            //chamando a classe para o programa.
            Convidados conv = new Convidados();

            

            Console.WriteLine("\nFesta Do @");

            Console.WriteLine("\nDigite o número de convidados do noivo: ");
            noivo = Convert.ToInt16(Console.ReadLine());//Lendo e convertendo a variável.

            Console.WriteLine("\nDigite o número de convidados da noiva: ");
            noiva = Convert.ToInt16(Console.ReadLine());//Lendo e convertendo a variável.

            Console.WriteLine("\nDigite o número de convidados presentes do noivo: ");
            convidadosNoivo = Convert.ToInt16(Console.ReadLine());//Lendo e convertendo a variável.

            Console.WriteLine("\nDigite o número de convidados presentes da noiva: ");
            convidadosNoiva = Convert.ToInt16(Console.ReadLine());//Lendo e convertendo a variável.


            Console.WriteLine("\n_____________________________________________________________________________________\n");
            //Condição para verificar se todos os convidados vieram ou se há penatras.-Noivo
            if (convidadosNoivo <= noivo)
            {
                Console.WriteLine("\nO Número de convidados do Noivo é: " + noivo);
                Console.WriteLine("\nO Número de convidados presente é: " + convidadosNoivo);
                Console.WriteLine("\nA maioria dos convidados do noivo vieram");
            }
            else
            {
                Console.WriteLine("\nO Número de convidados do Noivo é: " + noivo);
                Console.WriteLine("\nO Número de convidados presente é: " + convidadosNoivo);
                Console.WriteLine("\nPossivelmente há 'penetras' entre os convidados do noivo");
            }

            Console.WriteLine("\n_____________________________________________________________________________________\n");

            //Condição para verificar se todos os convidados vieram ou se há penatras.-Noiva
            if (convidadosNoiva <= noiva)
            {
                Console.WriteLine("\nO Número de convidados do Noivo é: " + noiva);
                Console.WriteLine("\nO Número de convidados presente é: " + convidadosNoiva);
                Console.WriteLine("\nA maioria dos convidados da noiva vieram");
            }
            else
            {
                Console.WriteLine("\nO Número de convidados do Noivo é: " + noiva);
                Console.WriteLine("\nO Número de convidados presente é: " + convidadosNoiva);
                Console.WriteLine("\nPossivelmente há 'penetras' entre os convidados da noiva");
            }

            Console.WriteLine("\n_____________________________________________________________________________________\n");

            //Amostra total de convidados e convidados presentes
            Console.WriteLine("\n O Número total de convidados para a festa é: " + conv.Total(noivo, noiva));
            Console.WriteLine("\n O Número total de convidados que compareceram a festa é: " + conv.TotalPresentes(convidadosNoivo, convidadosNoiva));

            Console.WriteLine("\n_____________________________________________________________________________________\n");

        }
    }
}
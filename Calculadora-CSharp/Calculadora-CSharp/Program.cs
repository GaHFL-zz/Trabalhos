using System;

namespace ConsoleApp1
{

    public class Calculadora
    {
        public double resultadosoma;
        public double Soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double resultadosub;
        public double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public double resultadodiv;
        public double Divisao(double num1, double num2)
        {
            return num1 / num2;
        }

        public double resultadomulti;
        public double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            

            string entrada;
            string operacao;
            Calculadora Calc = new Calculadora();

            Console.WriteLine("\n Olá, sou sua calculadora!\n");
            Console.WriteLine("\n Para começar, digite um número:  ");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n Escolha a operação!\n");
            operacao = Console.ReadLine();

            Console.WriteLine("\n Para efetuar o calculo, digite mais um número:  ");
            entrada = Console.ReadLine();
            num2 = Convert.ToDouble(entrada);

            switch (operacao)
            {
                case "+":

                    Console.WriteLine("\n O resultado é: " + Calc.Soma(num1, num2));
                    break;
                case "-":

                    Console.WriteLine("\n O resultado é: " + Calc.Subtracao(num1, num2));
                    break;
                case "/":
                    if (num2 == 0) //caso o num2 for zero, nÃ£o existe divisÃ£o por zero.
                    {
                        Console.WriteLine("Impossível dividir por 0");
                    }
                    else//continuando, caso num2 nÃ£o for zero...
                    {
                        Console.WriteLine("\n O resultado é: " + Calc.Divisao(num1, num2));
                    }
                    break;
                case "*":
                    Console.WriteLine("\n O resultado é: " + Calc.Multiplicacao(num1, num2));
                    break;

            }
        }
    }

}


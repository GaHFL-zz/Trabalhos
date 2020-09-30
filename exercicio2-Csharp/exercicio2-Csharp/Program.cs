using System;

namespace exercicio2_Csharp
{
        public class Pessoa
        {
            public Pessoa() { }

            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                this.Nome = nome;
            }
        }
    class Program
    {
        static List <Pessoa> convidado;
        static void Main(string[])
        {
            convidado = new List <Pessoa> ();

            string alguem;

            Console.WriteLine("Quem você deseja adicionar a lista? ");
            alguem = Console.ReadLine();

            convidado.add(alguem);
            //http://www.macoratti.net/17/06/c_listas1.htm
        }
    }
}

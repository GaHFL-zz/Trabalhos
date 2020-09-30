using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 6;
            vetor[2] = 2;
            vetor[3] = 5;

            int valor = vetor[1];
            System.Array.Sort(vetor);

            for (int index =0; index<4; index++)
            {
                MessageBox.Show(vetor[index].ToString(), "Array");
            }
            /*Declarar e instancia vetor
            atribuição de valores de acordo com cada indice
            declaração de variavel "Valor" para acessar o vetor
            system.array.sort - esta classe ordena o vetor
            comando for - percorre o vetor em cada índice.
            condição - para index menor que 4 , 
            ele exibe uma msg com o vetor na Messagebox.*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda";
            semana[2] = "Terça";
            semana[3] = "Quarta";
            semana[4] = "Quinta";
            semana[5] = "Sexta";
            semana[6] = "Sabado";

            string valor = semana[1];
            
            for(int index = 0; index <7; index++)
            {
                MessageBox.Show(semana[index].ToString(), "Array");
            }
            /*Declarar e instaciar vetor 
             atrinbuição de valores de acordo com cada indice,
             aqui no caso são os dias da semana(string)
             declaração de variavel "valor" para acessar o vetor
             Por se tratar de string não será necessário ordenar
             comando for - percorre o vetor em cada indice.
             condicção para o index menor que 7,
             ele exibe uma msg com o vetor, ou seja
             cada dia da semana*/
        }
    }
}

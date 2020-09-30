using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Básico
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;


        /*Declaração de 3 arrays para armazenar 10 produtos
         e seus respectivos códigos e valores
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
            /*inicia com uma condição, se o usuário digitar um codigo com 3 
             * caracteres(length), esse codigo é adicionado ao ListBox.
             A propriedade Lengh retorna a quantidade de caracteres.
             após o conteudo ser enviado para o ListBox, o TextBox será limpo
             e o Focus posiciona o cursor para o TextBox para
             uma nova digitação*/
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                    /*\faça enquanto o prod for menor ou igual a qtd 
                     de itens do array*/
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                    
                }
                /*condição se não for encontrado o produto
                 ele retorna as informações de acordo com o índice
                 caso não encontre, aparecerá a mensagem, produto não encontrado*/

                if(indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");

                }else  //conteudo adicionado no Listbox, concatena(+) as informações.
                    {
                        lstCaixa.Items.Add(txtCodigo.Text + "--" + produtos[indice] + "-- R$" + valor[indice]);

                        soma = soma + valor[indice];
                        label3.Text = ("Valor Total R$" + soma);
                        pictureBox1.ImageLocation = "c:/imagens/" + codigo[indice] + "jpg";
                        txtCodigo.Text = "";
                        txtCodigo.Focus();

                        /*Localização da imagem que deve ser colocada em uma pasta em:
                         c: em uma pasta imagens
                            o textBox será limpo e o focus
                            posiciona o cursor para o TextBox para uma nova digitação*/
                    }

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarArray();
            soma = 0;

        }
        /*Ao entrar no form load será chamado o método*/

        private void CarregarArray()
        {
            /*criação de método para ser chamado quando
             necessário isso evita repetir várias veze4s o mesmo codigo*/

            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Refrigerante";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.52;
            valor[5] = 8.00;
            /*Códigos, produtos e valores ref. os arquivos que foram declarados*/
        }
    }
}

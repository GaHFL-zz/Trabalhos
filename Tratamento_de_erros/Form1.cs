using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_de_erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            //usa-se try e catch tratar de um erro visível, como digitar letras em lugar de número
            //dessa forma, pode-se usar para outros tipos de erros relacionados

            /*explicação - try e catch
             um bloco try é chamado de bloco de proteção. caso ocorra algum problema com os comandos
             dentro do bloco, a execução desviará para os blocos catch correspondentes*/
            try
            {
                num1 = int.Parse(TxtNum1.Text);
                num2 = int.Parse(TxtNum2.Text);
                resultado = num1 + num2;
                TxtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos", "Catch");
            }
            /*explicação - finally
             O uso do bloco finally é opcional. No entanto, quando usamos o bloco, ele é executado 
             independentemente da ocorrência ou não de erro, como uma mensagem para fechar o programa.*/
            finally
            {
                MessageBox.Show("Aperte ok para sair!");
                Close();
            }
        }
    }
}

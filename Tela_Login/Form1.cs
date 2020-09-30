using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = textUsuario.Text;
            senha = textSenha.Text;

            if(usuario == "admin" && senha == "admin")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
                /*Declaração de variáveis e atribuição
                 * condição - se o usuário e senha forem
                 * iguais a admin, será chamado o form2.
                 * ou seja, ele terá acesso ao sistema, somente se
                 * o usuário e senha estiverem corretos.
                 */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

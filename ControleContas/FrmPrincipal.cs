using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ControleContas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /*try
        {
                //conectar ao banco
                MySqlConnection CON = new MySqlConnection("server=localhost; port=3306; User id=root; database=controlecontas; password=Gabs*1011");
        //abrir o banco
        CON.Open();
                MessageBox.Show("Conectado");
                //fechar o banco
                CON.Close();
            }
            catch
            {
                MessageBox.Show("não conectado");
         }*/

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {   
        }

    }
}

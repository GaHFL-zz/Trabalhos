using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Banco_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            /*Lista de eventos para criação Manual
             * 1.Localize a janela Server Explore, use o atalho "CTRL + ALT + S"
             * 2.Na janela Server Explore, clique no botão Connect to Database(Conectar a um BD).
             * 3.Selecione o Banco de Dados que vai ser conectado.
             * 4.A janela add connection: Em Server Name, todos os serviços disponíveis na maq serão procurados
             * Selecione o SQL Express e clique em Test Connection. resultado:Test Connection Succeeded
             * 5.Conclua com Ok
             * 6. Após esse passo, voce perceberá qua irá surgir uma nova conexão na janela Server Explore.
             * Essa identificação pode variar de pc para pc.
             * 7.~Para vizualizar o nome clique na Server Explore com o botão direito. em seguida , clique na conexão
             * que acabou de criar e escolha a opção Modify Connection. Em seguida no botão::advanced
             * 8.copie o nome que ver
             * 9.Na solution Explore. Clique no nome do projeto com o botão direito e esolha a opção proprieties.
             * 10. Vá para settings. Faça algumas alterações em Name="CST" type="Connection String" e Scope="Aplication"
             * em value = clique "..." para entrar em propriedades.
             * Na janela Connection Porprieties, selecione a opção SQLEXPRESS, no campo Server Name. Clique em ok.
             */

            //cód para criar a conexão de banco de dados
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            /*criando conexão nome con,
             Recuperando junto as propriedades, apos digitar o Default observe que aparecerá
             uma lista de opções e nesta lista deve aparecer o nome que escolhemos nas
             propriedades/settings do projeto anteriormente. No caso CS*/

            try
            {
                con.Open();

                //criando o sql command, selecionando todos os dados na tb_clientes
                SqlCommand Cnn = new SqlCommand();
                Cnn.CommandText = "SELECT *FROM tb_Clientes";
                Cnn.CommandType = CommandType.Text;
                Cnn.Connection = con;
                SqlDataReader DR;
                DR = Cnn.ExecuteReader();

                //Carregar os dados do DATAGRI
                DataTable dt = new DataTable();
                dt.Load(DR);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                /*8Repita esses passo
                *9.Na solution Explore. Clique no nome do projeto com o botão direito e esolha a opção proprieties.
                10. Vá para settings: em value = clique "..." para entrar em propriedades.
                11. Na janela Connection Porpreities, temos que selecionar o banco de dados na opção Connect a Database.
                12. conect o seu banco criado. teste. ok
                13. volte para settings. Veja se a Connection String foi atualizada com os dados do banco. Salve.*/

                con.Close();

                MessageBox.Show("A conexão foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Falha na conexão:{0}", ex.Message));

                /*Abriu e fechou a conexão
                 exibir mensagem se a conexão foi realizada com sucesso,
                 caso dê algum erro ele irá direto para o catch e exibirá
                 a msg de falha*/
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ContasAReceber
{
    class Conexao //Classe para criar uma conexão com o banco de dados.
    { 
        MySqlConnection CON = new MySqlConnection(); //Instancia para conexão.
        
        public Conexao () //Construtor para iniciar a classe.
        {
            CON.ConnectionString = "server=127.0.0.1;user id=root;database=controlecontas; Pwd=Gabs*1011";
        }

        public MySqlConnection Open() //Abrir o BD.
        {
            if (CON.State == ConnectionState.Closed)
            {
                CON.Open();
            }
            return CON;
        }

        public void Closed() //Fechar o DB.
        {
            if(CON.State == ConnectionState.Open)
            {
                CON.Close();
            }
        }
    }
}

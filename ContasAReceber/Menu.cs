using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAReceber
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnContasAreceber_Click(object sender, EventArgs e)
        {
            //Butão Contas a receber ligando a tela contas a receber.
            ContaReceber conta = new ContaReceber();
            conta.ShowDialog();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            Movimentacao mov = new Movimentacao();
            mov.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

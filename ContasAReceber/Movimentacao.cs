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
    public partial class Movimentacao : Form
    {
        public Movimentacao()
        {
            InitializeComponent();
        }

        Controller_ContasReceber control = new Controller_ContasReceber();

        private void Movimentacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controlecontasDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.controlecontasDataSet.categoria);
            dtgTable.DataSource = control.Table();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Caixa para fechar a tela Movimentações Botão Sair
            DialogResult msg;
            msg = MessageBox.Show("Deseja realmente Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg.ToString().Equals("Yes"))
            {
                Close();
            }
        }
    }
}

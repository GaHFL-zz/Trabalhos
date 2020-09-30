using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_cadastro_de_usuários_LOJA
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamada do form Cadastro_usuário no formato de MDi,
            //ou seja para abrir dentro do form principal (MDI)
            //chama-se janelha filha. (ChildForm), fica dentro da janela mãe

            Form childform = new Cadastro_usuario();
            childform.MdiParent = this;
            childform.Show();
        }
    }
}

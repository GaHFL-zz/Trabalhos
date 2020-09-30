using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DTO;
using Loja.BLL;
namespace Loja
{
    public partial class Cadastro_usuario : Form
    {
        string modo = "";
        /* SELECIONADO*/
        int codUsuSelecionado = -1;
        public Cadastro_usuario()
        {
            InitializeComponent();
        }
        private void Cadastro_usuario_Load(object sender, EventArgs e)
        /* método carregaGrid.
        Para atualizar os dados do Grid.
        Basta chamar o método. */
        {
            carregaGrid();
            lblMensagem.Text = "";
        }
        private void carregaGrid()
        {
            try
            {
                IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();
                /*Carregar os dados dos usuarios no DataGridView*/
                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            /*Chamando Método Limpar Campos que foi criado*/
            limpar_campos();
            /*inserindo data atual automaticamente no txtCadastro, ao clicar no botão Novo*/
            txtCadastro.Text = Convert.ToString(System.DateTime.Now);
            /*após clicar no botão NOVO, modo passa a ser novo (incluindo um registro)*/
            modo = "novo";
        }
        /*Criando Método Limpar Campos, para que todas as vezes em
        que for necessário limpar não será necessário repetir o código,
        apenas chamar o método*/
        private void limpar_campos()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtCadastro.Text = "";
            cboPerfil.Text = "";
            cboSituacao.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Linha atual que estiver selecionada aparecerá nos campos (textbox) acima do
            dataGrid*/
            int sel = dataGridView1.CurrentRow.Index;
            /*Valor de cada datagrid será enviado ao seu respectivo texbox*/
            txtNome.Text = Convert.ToString(dataGridView1["Nome", sel].Value);
            txtLogin.Text = Convert.ToString(dataGridView1["Login", sel].Value);
            txtEmail.Text = Convert.ToString(dataGridView1["Email", sel].Value);
            txtSenha.Text = Convert.ToString(dataGridView1["Senha", sel].Value);
            txtCadastro.Text = Convert.ToString(dataGridView1["Cadastro", sel].Value);
            codUsuSelecionado = Convert.ToInt32(dataGridView1["cod_usuario", sel].Value);
            /*Condição se a situação for igual a "A" então o combobox ficará Ativo senao "Inativo"
            */
            if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
            {
                cboSituacao.Text = "Ativo";
            }
            else
            {
                cboSituacao.Text = "Inativo";
            }
            switch (Convert.ToString(dataGridView1["perfil", sel].Value))
            {
                /*Caso seja 1, será escolhido Administrados, caso seja 2, operador e caso 3,
    Gerencial" */
                case "1":
                    cboPerfil.Text = "Administrador";
                    break;
                case "2":
                    cboPerfil.Text = "Operador";
                    break;
                case "3":
                    cboPerfil.Text = "Gerencial";
                    break;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (codUsuSelecionado < 0)
            {
                lblMensagem.Text = "Selecione um usuario antes de prosseguir";
                return;
            }
            modo = "altera";
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (codUsuSelecionado < 0)
            {
                lblMensagem.Text = "Selecione um usuario antes";
                return;
            }
            else
            {
                lblMensagem.Text = "";
                modo = "excluir";
                MessageBox.Show("Para excluir o usuario, clique em Confirmar");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "";
            limpar_campos();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                /*Tratamento de Erros, exibe msg*/
                try
                {
                    /*Objeto USU*/
                    usuario_DTO USU = new usuario_DTO();
                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.email = txtEmail.Text;
                    USU.cadastro = System.DateTime.Now;
                    USU.senha = txtSenha.Text;
                    if (cboSituacao.Text == "Ativo")
                    {
                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }
                    switch (cboPerfil.Text)
                    {
                        case "Administrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    /*Método insere usuário na classe UsuarioBLL*/
                    int x = new UsuarioBLL().insereUsuario(USU);
                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com Sucesso!");
                    }
                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }
            if (modo == "altera")
            {
                /*Tratamento de Erros, exibe msg*/
                try
                {
                    if (codUsuSelecionado < 0)
                    {
                        lblMensagem.Text = "Selecione um usuario antes de prosseguir";
                        return;
                    }
                    /*Objeto USU, assim como feito no modo="novo"
                    Lê os textbox com os dados alterados*/
                    usuario_DTO USU = new usuario_DTO();
                    USU.cod_usuario = codUsuSelecionado;
                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.email = txtEmail.Text;
                    USU.cadastro = System.DateTime.Now;
                    USU.senha = txtSenha.Text;
                    if (cboSituacao.Text == "Ativo")
                    {
                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }
                    switch (cboPerfil.Text)
                    {
                        case "Administrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    int x = new UsuarioBLL().alteraUsuario(USU);
                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Alterado com Sucesso!");
                    }
                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }
            if (modo == "excluir")
            {
                try
                {
                    if (codUsuSelecionado < 0)
                    {
                        lblMensagem.Text = "Selecione um usuario antes de prosseguir";
                        return;
                    }
                    usuario_DTO USU = new usuario_DTO();
                    USU.cod_usuario = codUsuSelecionado;
                    int x = new UsuarioBLL().excluiUsuario(USU);
                    if (x > 0)
                    {
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGrid();
                    limpar_campos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }
            modo = "";
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (codUsuSelecionado < 0)
            {
                lblMensagem.Text = "Selecione um usuario antes";
                return;
            }
            modo = "altera";
        }
    }
}
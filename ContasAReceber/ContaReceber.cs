using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAReceber
{
    public partial class ContaReceber : Form
    {
        public ContaReceber()
        {
            InitializeComponent();
        }

        Controller_ContasReceber contas = new Controller_ContasReceber();
        Contasreceber conrecebe = new Contasreceber();
        private void LimpaCampos()
        {
            txbNTitulo.Clear();
            txbParcela.Clear();
            txbDataCadastro.Clear();
            cmbTipoCobranca.Text = "";
            cmbCliente.Text = "";
            txbCpf_Cnpj.Clear();
            cmbCategoria.Text = "";
            txbVencimento.Clear();
            txbValorTitulo.Clear();
            cmbSituacao.Text = "";
            txbObservacao.Clear();

        }
        private bool VerificarVazio()
        {
            if (txbNTitulo.Text != "" && txbParcela.Text != ""
                && txbDataCadastro.Text != "" && cmbTipoCobranca.Text != ""
                && cmbCliente.Text != "" //&& txbCpf_Cnpj.Text != ""
                 && cmbCategoria.Text != "" && txbVencimento.Text != "" 
                && txbValorTitulo.Text != "" && cmbSituacao.Text != "")
                return true;

            return false;
        }

        private void Transfer()
        {
            
            //Converter a String para Int
            conrecebe.nr_titulo = Convert.ToInt32(txbNTitulo.Text);
            conrecebe.parcela = Convert.ToInt32(txbParcela.Text);
            conrecebe.dataCadastro = Convert.ToDateTime(txbDataCadastro.Text);
            conrecebe.Fk_Id_tipo = Convert.ToInt32(cmbTipoCobranca.SelectedValue.ToString());
            conrecebe.Fk_Id_cliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            conrecebe.Fk_Id_situacao = Convert.ToInt32(cmbSituacao.SelectedValue.ToString());
            conrecebe.Fk_Id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
            conrecebe.vencimento = Convert.ToDateTime(txbVencimento.Text);
            conrecebe.valorTitulo = Convert.ToInt32(txbValorTitulo.Text);
            conrecebe.observacoes = txbObservacao.Text;

        }
        private void ContaReceber_Load(object sender, EventArgs e)
        {
            //Faz carregar as combobox
            //tipocobrança
            cmbTipoCobranca.DataSource = contas.Infor();
            cmbTipoCobranca.ValueMember = "Id_tipo";
            cmbTipoCobranca.DisplayMember = "tipo";

            //situaçao
            cmbSituacao.DataSource = contas.Infor_situacao();
            cmbSituacao.ValueMember = "Id_situacao";
            cmbSituacao.DisplayMember = "NomeSituacao";

            //Cliente
            cmbCliente.DataSource = contas.Infor_cliente();
            cmbCliente.ValueMember = "Id_cliente";
            cmbCliente.DisplayMember = "razao_Nome";

            //categoria
            cmbCategoria.DataSource = contas.Infor_categoria();
            cmbCategoria.ValueMember = "Id_categoria";
            cmbCategoria.DisplayMember = "NomeCategoria";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarVazio() == false)
            {
                MessageBox.Show("Há ainda campos vazios");
            }
            else
            {
                //chamando o método
                Transfer();
                //passando para o adicionar no contas recebe
                contas.Adicionar(conrecebe);
                MessageBox.Show("Cadastrado com sucesso");
                LimpaCampos();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {   
            //Caixa para fechar a tela. Botão Cancelar
            DialogResult msg;
            msg = MessageBox.Show("Deseja fechar a tela?", "Aviso" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg.ToString().Equals("Yes"))
            {
                Close();
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            contas.Mudar(txbCpf_Cnpj.Text, conrecebe);
        }
    }
}

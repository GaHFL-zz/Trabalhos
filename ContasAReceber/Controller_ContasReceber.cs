using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ContasAReceber
{
    class Controller_ContasReceber
    {
        Conexao conecta = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        public DataTable Table()
        {
            //comunicação com o BD
            cmd.CommandText = "SELECT contasreceber.nr_titulo, cliente.razao_Nome, categoria.NomeCategoria, contasreceber.dataCadastro, contasreceber.vencimento, contasreceber.valorTitulo, situacao.NomeSituacao, tipocobranca.tipo, contasreceber.observacoes FROM categoria INNER JOIN contasreceber ON categoria.Id_categoria = contasreceber.Fk_Id_categoria INNER JOIN cliente ON contasreceber.Fk_Id_cliente = cliente.Id_cliente INNER JOIN situacao ON contasreceber.Fk_Id_situacao = situacao.Id_situacao INNER JOIN tipocobranca ON contasreceber.Fk_Id_tipo = tipocobranca.Id_tipo";
            try
            {
                //abrir banco
                cmd.Connection = conecta.Open();
                //mexer com a tabela dentro do VS - criar um DataSet
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                //fazer alguma alteração
                DataTable dt = new DataTable();

                mda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {   //retornar algum erro
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        public void Adicionar(Contasreceber cr)
        {
            cmd.CommandText = "INSERT INTO contasreceber (" +
                                                        "nr_titulo," +
                                                        "parcela," +
                                                        "dataCadastro," +
                                                        "Fk_Id_cliente," +
                                                        "Fk_Id_categoria," +
                                                        "Fk_Id_tipo," +
                                                        "Fk_Id_situacao," +
                                                        "vencimento," +
                                                        "valorTitulo," +
                                                        "observacoes) Values (@nr_titulo," +
                                                        "@parcela," +
                                                        "@dataCadastro," +
                                                        "@Fk_Id_cliente," +
                                                        "@Fk_Id_categoria," +
                                                        "@Fk_Id_tipo," +
                                                        "@Fk_Id_situacao," +
                                                        "@vencimento," +
                                                        "@valorTitulo," +
                                                        "@observacoes)";

            cmd.Parameters.AddWithValue("@nr_titulo", cr.nr_titulo);
            cmd.Parameters.AddWithValue("@parcela", cr.parcela);
            cmd.Parameters.AddWithValue("@dataCadastro", cr.dataCadastro);
            cmd.Parameters.AddWithValue("@Fk_Id_cliente", cr.Fk_Id_cliente);
            cmd.Parameters.AddWithValue("@Fk_Id_categoria", cr.Fk_Id_categoria);
            cmd.Parameters.AddWithValue("@Fk_Id_tipo", cr.Fk_Id_tipo);
            cmd.Parameters.AddWithValue("@Fk_Id_situacao", cr.Fk_Id_situacao);
            cmd.Parameters.AddWithValue("@vencimento", cr.vencimento);
            cmd.Parameters.AddWithValue("@valorTitulo", cr.valorTitulo);
            cmd.Parameters.AddWithValue("@observacoes", cr.observacoes);

            try
            {
                cmd.Connection = conecta.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //retornar algum erro
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        public void Alterar(Contasreceber cr)
        {
            cmd.CommandText = "UPDATE contasreceber SET nr_titulo = @nr_titulo," +
                                                        "parcela = @parcela," +
                                                        "dataCadastro = @dataCadastro," +
                                                        "Fk_Id_cliente = @Fk_Id_cliente," +
                                                        "Fk_Id_categoria = @Fk_Id_categoria," +
                                                        "Fk_Id_tipo = @Fk_Id_tipo," +
                                                        "Fk_Id_situacao = @Fk_Id_situacao," +
                                                        "vencimento = @vencimento," +
                                                        "valorTitulo = @valorTitulo," +
                                                        "observacoes = @observacoes WHERE nr_titulo = @nr_titulo";

            cmd.Parameters.AddWithValue("@nr_titulo", cr.nr_titulo);
            cmd.Parameters.AddWithValue("@parcela", cr.parcela);
            cmd.Parameters.AddWithValue("@dataCadastro", cr.dataCadastro);
            cmd.Parameters.AddWithValue("@Fk_Id_cliente", cr.Fk_Id_cliente);
            cmd.Parameters.AddWithValue("@Fk_Id_categoria", cr.Fk_Id_categoria);
            cmd.Parameters.AddWithValue("@Fk_Id_tipo", cr.Fk_Id_tipo);
            cmd.Parameters.AddWithValue("@Fk_Id_situacao", cr.Fk_Id_situacao);
            cmd.Parameters.AddWithValue("@vencimento", cr.vencimento);
            cmd.Parameters.AddWithValue("@valorTitulo", cr.valorTitulo);
            cmd.Parameters.AddWithValue("@observacoes", cr.observacoes);

            try
            {
                cmd.Connection = conecta.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //retornar algum erro
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        public void Deletar(Contasreceber cr)
        {
            cmd.CommandText = "DELETE FROM contasreceber WHERE nr_titulo = @nr_titulo";

            cmd.Parameters.AddWithValue("@nr_titulo", cr.nr_titulo);

            try
            {
                cmd.Connection = conecta.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //retornar algum erro
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        //chamando informações para as combobox
        public DataTable Infor()
        {
            
            cmd.CommandText = "SELECT *FROM tipocobranca";
            try
            {
                cmd.Connection = conecta.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                DataTable dtt = new DataTable();
                dtt.Load(leitor);
                return dtt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }
        public DataTable Infor_situacao()
        {

            cmd.CommandText = "SELECT *FROM situacao";
            try
            {
                cmd.Connection = conecta.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                DataTable dtt = new DataTable();
                dtt.Load(leitor);
                return dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        public DataTable Infor_cliente()
        {
            
            cmd.CommandText = "SELECT *FROM cliente";
            try
            {
                cmd.Connection = conecta.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                DataTable dtt = new DataTable();
                dtt.Load(leitor);
                return dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

     
        public DataTable Infor_categoria()
        {

            cmd.CommandText = "SELECT *FROM categoria";
            try
            {
                cmd.Connection = conecta.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                DataTable dtt = new DataTable();
                dtt.Load(leitor);
                return dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }

        public void Mudar(String mud, Contasreceber cont)
        {
            //Selecte table no BD
            cmd.CommandText = "SELECT *FROM cliente WHERE Id_cliente = @cliente";
            //colocando parametros
            cmd.Parameters.AddWithValue("@cliente", cont.Fk_Id_cliente);
            try
            {
                cmd.Connection = conecta.Open();
                MySqlDataReader Msql = cmd.ExecuteReader();
                while (Msql.Read())
                {
                    mud = (string)Msql["cpf_cnpj"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conecta.Closed();
            }
        }
    }
}

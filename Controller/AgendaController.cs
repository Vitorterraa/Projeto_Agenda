using MySqlConnector;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class AgendaController
    {
        public bool AddContato(string contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {



                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                conexao.Open();

                string sql = "INSERT INTO tbcontato (contato, telefone, categoria) values (@contato, @telefone, @categoria);";



                MySqlCommand comando = new MySqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@contato", contato);

                comando.Parameters.AddWithValue("@telefone", telefone);

                comando.Parameters.AddWithValue("@categoria", categoria);


                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    return false;
                }



            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public DataTable GetContatos()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = @"SELECT id_contato as 'Código', contato as 'Contato', telefone as 'Telefone', categoria as 'Categoria' FROM tbcontato WHERE usuario = User()";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable(); adaptador.Fill(tabela);
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar contatos: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool ExContato(int id_contato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);


                string sql = @"delete from tbcontato
                                where id_contato = @id_contato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id_contato", id_contato);

                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }



            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar a exclusão: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public bool AltContato(int id_contato, string contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);


                string sql = @"update tbcontato 
                                set contato = @contato
                                where id_contato = @id_contato;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@id_contato", id_contato);

                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }



            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar a alteração: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

    }
}

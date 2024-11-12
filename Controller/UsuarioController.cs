using MySqlConnector;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario (string nome, string usuario, string telefone, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) values (@nome,  @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

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
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

        }

        public bool LogarUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = @"select * from tbusuarios
                                where usuario = @usuario 
                                and binary senha  = @senha;";




                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                

                if (resultado.Read())
                {
                    return true;
                }
                else
                { return false; }
                
            }
            catch
            {
                
                return false;
            }

        }
        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao,usei classe ConexaoDB
                conexao = ConexaoDB.CriarConexao();

                //comando sql para retornar os dados da tabela
                string sql = @"select usuario as 'Usuário',
                                nome as 'Nome',
                                telefone as 'Telefone'
                                from tbusuarios;";

                //abri a conexao
                conexao.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //criei apenas a tabela, vazia
                DataTable tabela = new DataTable();

                //o adaptador vai preencher a tabela com os dados
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir os usuários {erro.Message}");

                return new DataTable();


            }
            finally
            {
                conexao.Close();
            }
        }
        public bool ExUsuario(string usuario)
        {

            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();


                string sql = @"delete from tbusuarios
                                where usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

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
    }
}

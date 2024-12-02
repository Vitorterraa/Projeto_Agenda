using MySqlConnector;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
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
    }
}

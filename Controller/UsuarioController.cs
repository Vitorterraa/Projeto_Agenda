using MySqlConnector;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
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
                else { return false; }

            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

        }
    }
}

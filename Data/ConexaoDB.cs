using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    internal class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            // string contendo as informações para conexão
            string stringConexao = "server=localhost;Database=dbagenda;User ID=root;Password=root;";

            //Criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }

        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            // string contendo as iformações para conexão
            string stringConexao = $"server=localhost;Database=dbAgenda;User ID={usuario};Password={senha};";

            //Criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}

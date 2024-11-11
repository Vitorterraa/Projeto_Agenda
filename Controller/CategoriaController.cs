﻿using MySqlConnector;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();
                

                string sql = "INSERT INTO tbcategoria (categoria) values (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                
                comando.Parameters.AddWithValue("@categoria", categoria);
                
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
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao,usei classe ConexaoDB
                conexao = ConexaoDB.CriarConexao();

                //comando sql para retornar os dados da tabela
                string sql = @"select id_categoria as 'Código',
                                categoria as 'Categoria'
                                from tbcategoria;";


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
                MessageBox.Show($"Erro ao recuperar categorias {erro.Message}");

                return new DataTable();


            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

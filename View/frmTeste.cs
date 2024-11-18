using MySqlConnector;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Controller
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao("Arceus", "123");
                conexao.Open();

                MessageBox.Show("Deu certo!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não consegui conectar");
            }
        }
    }
}

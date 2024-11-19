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
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda.Controller
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.usuario = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserSession.nome = textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.nome);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.senha);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserSession.senha = textBox3.Text;
        }
    }
}

using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.View
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(txtNomeCategoria.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao efetuar seu cadastro");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

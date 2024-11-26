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

        private void AtualizaDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = txtNomeCategoria.Text;

            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(categoria);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao efetuar seu cadastro");
            }


            DataTable tabela = controleCategoria.GetCategorias();

            dgvCategoria.DataSource = tabela;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();

            dgvCategoria.DataSource = tabela;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

            CategoriaController controleUsuario = new CategoriaController();

            bool resultado = controleUsuario.ExCategoria(codigo);

            if (resultado == true)
            {
                MessageBox.Show("Exclusão efetuada com sucesso!!");
                AtualizaDataGrid();

            }
            else
            {
                MessageBox.Show("Erro ao excluir sua categoria");
            }

        }

        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();

            dgvCategoria.DataSource = tabela;

            AtualizaDataGrid();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int categoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController alterarcategoria = new CategoriaController();
            alterarcategoria.AltCategoria(txtNomeCategoria.Text, categoria);

            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;

        }
    }
}

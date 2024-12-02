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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();

            AtualizaDataGrid();
        }
        private void AtualizaDataGrid()
        {
          
           AgendaController controleContatos = new AgendaController();
           DataTable tabela = controleContatos.GetContatos();
           dgvAgenda.DataSource = tabela;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            
            //cmbCategoria.DataSource = tabela;
            //cmbCategoria.DisplayMember = "categoria";
            //cmbCategoria.ValueMember = "id_categoria";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells[0].Value);

            AgendaController controleContato = new AgendaController();

            bool resultado = controleContato.ExContato(codigo);

            if (resultado == true)
            {
                MessageBox.Show("Exclusão efetuada com sucesso!!");
                AtualizaDataGrid();

            }
            else
            {
                MessageBox.Show("Erro ao excluir seu contato");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contato = txtContato.Text;

            string telefone = txtTelefone.Text;

            string categoria = txtCategoria.Text;

            AgendaController controleAgenda = new AgendaController();

            bool resultado = controleAgenda.AddContato(contato, telefone, categoria);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao efetuar seu cadastro");
            }


            DataTable tabela = controleAgenda.GetContatos();

            dgvAgenda.DataSource = tabela;
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

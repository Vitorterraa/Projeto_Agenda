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
    public partial class frmAltUsuario : Form
    {
        public frmAltUsuario()
        {
            InitializeComponent();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAltUsuario_Load(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();
            DataTable tabela = controleUsuario.GetUsuarios();

            dgvUsuario.DataSource = tabela;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = (string)dgvUsuario.SelectedRows[0].Cells[0].Value;



            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.ExUsuario(usuario);

            if (resultado == true)
            {
                MessageBox.Show("Exclusão efetuada com sucesso!!");
                UsuarioController controleUsuarios = new UsuarioController();
                DataTable tabela = controleUsuarios.GetUsuarios();
                dgvUsuario.DataSource = tabela;

            }
        }
    }
}

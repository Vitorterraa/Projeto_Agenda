using ProjetoAgenda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblSejaBemVindo.Text = $"Seja bem vindo {VariableGlobal.UserSession.Nome}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria formularioCategorias = new frmCategoria();
            formularioCategorias.ShowDialog();
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltUsuario formularioUsuario = new frmAltUsuario();
            formularioUsuario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda formularioAgenda = new frmAgenda();
            formularioAgenda.ShowDialog();
        }

        private void alterarSenhaUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltUsuario formularioAlterarSenha = new frmAltUsuario();
            formularioAlterarSenha.ShowDialog();
        }

        private void lblSejaBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

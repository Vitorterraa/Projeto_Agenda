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

        }
    }
}

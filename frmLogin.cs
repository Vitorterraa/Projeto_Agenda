using ProjetoAgenda.Controller;

namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void HabilitarBotaoLogin()
        {
            if (txtSenha.Text.Length >= 8 && txtUsu�rio.Text != "")
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro formularioCadastro = new frmCadastro();
            formularioCadastro.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario("@usuario", "@senha");

            

            if (resultado == true) 
            {
                frmDentro formularioDentro = new frmDentro();
                formularioDentro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro!!");
            }

            
        }

        private void txtUsu�rio_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoLogin();
        }
    }
}

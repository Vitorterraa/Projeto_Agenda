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

            

            if (txtUsu�rio.Text.Length > 0 && txtSenha.Text.Length >= 4)
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


            string usuario = txtUsu�rio.Text;

            string senha = txtSenha.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario(txtUsu�rio.Text, txtSenha.Text);

            


            if (resultado == true) 
            {
                frmPrincipal formularioPrincipal = new frmPrincipal();
                formularioPrincipal.ShowDialog();
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

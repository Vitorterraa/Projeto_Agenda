using ProjetoAgenda.Controller;
using ProjetoAgenda.VariableGlobal;

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

            

            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length >= 4)
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


            string usuario = txtUsuario.Text;

            string senha = txtSenha.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario(txtUsuario.Text, txtSenha.Text);


            UserSession.usuario = txtUsuario.Text;

            UserSession.senha = txtSenha.Text;

            if (resultado == true) 
            {
                frmPrincipal formularioPrincipal = new frmPrincipal();
                this.Hide();
                formularioPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario nao encontrado");
            }
                   

        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoLogin();
        }
    }
}

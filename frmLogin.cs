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
            if (txtSenha.Text.Length >= 8 && txtUsuário.Text != "")
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
            frmDentro formularioDentro = new frmDentro();
            formularioDentro.ShowDialog();
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

namespace ProjetoAgenda
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsuario = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            btnEntrar = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(68, 83);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 26);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuário_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 53);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(68, 160);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '❌';
            txtSenha.Size = new Size(321, 26);
            txtSenha.TabIndex = 0;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Black;
            btnEntrar.Enabled = false;
            btnEntrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(68, 244);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(134, 42);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Logar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Black;
            btnCadastro.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(255, 244);
            btnCadastro.Margin = new Padding(3, 2, 3, 2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(134, 42);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = Properties.Resources.categoria_sao_paulo;
            ClientSize = new Size(484, 365);
            Controls.Add(btnCadastro);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Button btnEntrar;
        private Button btnCadastro;
    }
}

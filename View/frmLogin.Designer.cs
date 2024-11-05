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
            txtUsuário = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            btnEntrar = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // txtUsuário
            // 
            txtUsuário.Location = new Point(78, 111);
            txtUsuário.Multiline = true;
            txtUsuário.Name = "txtUsuário";
            txtUsuário.Size = new Size(366, 33);
            txtUsuário.TabIndex = 0;
            txtUsuário.TextChanged += txtUsuário_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 71);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(78, 214);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '❌';
            txtSenha.Size = new Size(366, 33);
            txtSenha.TabIndex = 0;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 174);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Black;
            btnEntrar.Enabled = false;
            btnEntrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(78, 325);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(153, 56);
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
            btnCadastro.Location = new Point(291, 325);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(153, 56);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(553, 487);
            Controls.Add(btnCadastro);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuário);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuário;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Button btnEntrar;
        private Button btnCadastro;
    }
}

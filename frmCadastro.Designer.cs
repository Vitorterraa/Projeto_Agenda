namespace ProjetoAgenda
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            label1 = new Label();
            txtUsuário = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            txtSenhaRep = new TextBox();
            label5 = new Label();
            btnCadastro = new Button();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 3;
            label1.Text = "Usuário:";
            // 
            // txtUsuário
            // 
            txtUsuário.Location = new Point(12, 148);
            txtUsuário.Multiline = true;
            txtUsuário.Name = "txtUsuário";
            txtUsuário.Size = new Size(366, 33);
            txtUsuário.TabIndex = 2;
            txtUsuário.TextChanged += txtUsuário_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 73);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(366, 33);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 26);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 236);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(366, 33);
            txtTelefone.TabIndex = 2;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(125, 26);
            label3.TabIndex = 3;
            label3.Text = "Telefone:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 319);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '❌';
            txtSenha.Size = new Size(230, 33);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(125, 26);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // txtSenhaRep
            // 
            txtSenhaRep.Location = new Point(12, 406);
            txtSenhaRep.Multiline = true;
            txtSenhaRep.Name = "txtSenhaRep";
            txtSenhaRep.PasswordChar = '❌';
            txtSenhaRep.Size = new Size(230, 33);
            txtSenhaRep.TabIndex = 2;
            txtSenhaRep.TextChanged += txtSenhaRep_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 377);
            label5.Name = "label5";
            label5.Size = new Size(183, 26);
            label5.TabIndex = 3;
            label5.Text = "Repita a senha:";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Black;
            btnCadastro.Enabled = false;
            btnCadastro.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(89, 489);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(153, 56);
            btnCadastro.TabIndex = 4;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 128, 128);
            btnEntrar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(297, 489);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(153, 56);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Cancelar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(568, 590);
            Controls.Add(btnCadastro);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtSenhaRep);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuário);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastro";
            Text = "frmCadastro";
            FormClosed += frmCadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuário;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private TextBox txtSenhaRep;
        private Label label5;
        private Button btnCadastro;
        private Button btnEntrar;
    }
}
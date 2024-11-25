namespace ProjetoAgenda.View
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            dgvCategoria = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtNomeCategoria = new TextBox();
            button2 = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(379, 12);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 62;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(412, 208);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            dgvCategoria.SelectionChanged += dgvCategoria_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNomeCategoria);
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(20, 78);
            button1.Name = "button1";
            button1.Size = new Size(283, 30);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(21, 41);
            txtNomeCategoria.Multiline = true;
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(283, 33);
            txtNomeCategoria.TabIndex = 0;
            txtNomeCategoria.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(21, 114);
            button2.Name = "button2";
            button2.Size = new Size(283, 28);
            button2.TabIndex = 3;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(21, 148);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(282, 29);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sao_paulo_fundo2;
            ClientSize = new Size(797, 233);
            Controls.Add(groupBox1);
            Controls.Add(dgvCategoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategoria;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtNomeCategoria;
        private Button btnAlterar;
        private Button button2;
    }
}

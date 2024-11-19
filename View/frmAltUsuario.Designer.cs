namespace ProjetoAgenda.View
{
    partial class frmAltUsuario
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
            dgvUsuario = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(30, 11);
            dgvUsuario.Margin = new Padding(3, 4, 3, 4);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersWidth = 62;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(365, 227);
            dgvUsuario.TabIndex = 2;
            dgvUsuario.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(30, 245);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(365, 49);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 34);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 43);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(478, 26);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(296, 144);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Altere a senha";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(5, 81);
            btnAlterar.Margin = new Padding(2, 2, 2, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(286, 34);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // frmAltUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 329);
            Controls.Add(button1);
            Controls.Add(dgvUsuario);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAltUsuario";
            Text = "frmAltUsuario";
            Load += frmAltUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuario;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnAlterar;
    }
}
namespace ProjetoAgenda.View
{
    partial class frmAgenda
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
            dgvAgenda = new DataGridView();
            groupBox1 = new GroupBox();
            cmbCategoria = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            txtTelefone = new TextBox();
            label1 = new Label();
            txtContato = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(406, 12);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.Size = new Size(382, 426);
            dgvAgenda.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Location = new Point(39, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 369);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar contato";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(6, 205);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(274, 23);
            cmbCategoria.TabIndex = 9;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(6, 314);
            button3.Name = "button3";
            button3.Size = new Size(274, 35);
            button3.TabIndex = 8;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F);
            button2.Location = new Point(167, 268);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 7;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F);
            button1.Location = new Point(6, 268);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F);
            label3.Location = new Point(6, 170);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 5;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F);
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 3;
            label2.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 123);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(274, 30);
            txtTelefone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 1;
            label1.Text = "Contato:";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(6, 54);
            txtContato.Multiline = true;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(274, 30);
            txtContato.TabIndex = 0;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_agenda;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvAgenda);
            Name = "frmAgenda";
            Text = "frmAgenda";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgenda;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox txtTelefone;
        private Label label1;
        private TextBox txtContato;
        private ComboBox cmbCategoria;
    }
}
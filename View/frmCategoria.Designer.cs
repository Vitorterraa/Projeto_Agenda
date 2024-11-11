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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtNomeCategoria = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNomeCategoria);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(21, 89);
            button1.Name = "button1";
            button1.Size = new Size(283, 38);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(21, 33);
            txtNomeCategoria.Multiline = true;
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(283, 33);
            txtNomeCategoria.TabIndex = 0;
            txtNomeCategoria.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(326, 154);
            dataGridView1.TabIndex = 1;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 229);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtNomeCategoria;
        private DataGridView dataGridView1;
    }
}
﻿namespace ProjetoAgenda.View
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
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            txtNomeCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(541, 20);
            dgvCategoria.Margin = new Padding(4, 5, 4, 5);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 62;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(588, 346);
            dgvCategoria.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNomeCategoria);
            groupBox1.Location = new Point(48, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(467, 346);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(1, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 145);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecione na tabela a categoria que deseja excluir";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(29, 53);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(404, 63);
            button2.TabIndex = 3;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(29, 130);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(404, 63);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(30, 68);
            txtNomeCategoria.Margin = new Padding(4, 5, 4, 5);
            txtNomeCategoria.Multiline = true;
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(403, 52);
            txtNomeCategoria.TabIndex = 0;
            txtNomeCategoria.TextChanged += textBox1_TextChanged;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sao_paulo_fundo2;
            ClientSize = new Size(1139, 389);
            Controls.Add(groupBox1);
            Controls.Add(dgvCategoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategoria;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox txtNomeCategoria;


     }
}

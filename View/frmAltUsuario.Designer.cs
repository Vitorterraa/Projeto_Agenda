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
            dgvCategoria = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(37, 14);
            dgvCategoria.Margin = new Padding(4, 5, 4, 5);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 62;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(456, 284);
            dgvCategoria.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(37, 306);
            button1.Name = "button1";
            button1.Size = new Size(456, 61);
            button1.TabIndex = 3;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAltUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 411);
            Controls.Add(button1);
            Controls.Add(dgvCategoria);
            Name = "frmAltUsuario";
            Text = "frmAltUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategoria;
        private Button button1;
    }
}
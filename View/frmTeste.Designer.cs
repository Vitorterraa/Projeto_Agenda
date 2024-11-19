namespace ProjetoAgenda.Controller
{
    partial class frmTeste
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 48);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(437, 300);
            button1.Name = "button1";
            button1.Size = new Size(249, 77);
            button1.TabIndex = 3;
            button1.Text = "Mostra-usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 151);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(487, 48);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(437, 397);
            button4.Name = "button4";
            button4.Size = new Size(249, 70);
            button4.TabIndex = 6;
            button4.Text = "Mostra-nome";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(437, 487);
            button6.Name = "button6";
            button6.Size = new Size(249, 71);
            button6.TabIndex = 8;
            button6.Text = "Mostra-senha";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 300);
            button2.Name = "button2";
            button2.Size = new Size(264, 77);
            button2.TabIndex = 1;
            button2.Text = "Guarda-usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(133, 397);
            button3.Name = "button3";
            button3.Size = new Size(264, 70);
            button3.TabIndex = 5;
            button3.Text = "Guarda-nome";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(133, 487);
            button5.Name = "button5";
            button5.Size = new Size(264, 71);
            button5.TabIndex = 7;
            button5.Text = "Guarda-senha";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 228);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(487, 49);
            textBox3.TabIndex = 9;
            // 
            // frmTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTeste";
            Text = "frmTeste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button4;
        private Button button6;
        private Button button2;
        private Button button3;
        private Button button5;
        private TextBox textBox3;
    }
}
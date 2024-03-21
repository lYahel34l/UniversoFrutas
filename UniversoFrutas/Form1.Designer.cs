namespace UniversoFrutas
{
    partial class Form1
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rosa", "Verde", "Marrón", "Morado", "Rojo", "Amarillo", "Naranja", "Negro" });
            comboBox1.Location = new Point(40, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 2;
            label1.Text = "La Fruta Por Fuera es color";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Blanco", "Verde", "Marrón", "Rojo", "Transparente", "Amarillo", "Morado", "Naranja" });
            comboBox2.Location = new Point(40, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 4;
            label2.Text = "La fruta por dentro es color";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Dulce", "Neutro", "Ácido" });
            comboBox3.Location = new Point(40, 159);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(146, 23);
            comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Sabor de la Fruta";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Hueso", "Semilla" });
            comboBox4.Location = new Point(40, 222);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(145, 23);
            comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 204);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 8;
            label4.Text = "Tiene Hueso o Semillas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox4;
        private Label label4;
    }
}

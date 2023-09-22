namespace DimaProj
{
    partial class PassagerForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 323);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 23;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 294);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 22;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 21;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 18;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 17;
            label1.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 27;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 26;
            label4.Text = "Фамилия";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 29;
            label5.Text = "Рейс";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 30;
            // 
            // PassagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(168, 368);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PassagerForm";
            Text = "PassagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
    }
}
namespace NameSurnameForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Corbel", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(86, 200);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 0;
            button1.Text = "Aktar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Adınız:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 94);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 147);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Mesleğiniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 36);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 94);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 147);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(808, 457);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(672, 321);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
    }
}
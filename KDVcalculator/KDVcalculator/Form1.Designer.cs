namespace KDVcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 51);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 0;
            label1.Text = "Ürün Çeşidi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 1;
            label2.Text = "Fiyat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 165);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 2;
            label3.Text = "KDV Oranı:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Laptop", "Cep Telefonu", "Beyaz Eşya", "Tablet" });
            comboBox1.Location = new Point(162, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0,08", "0,18" });
            comboBox2.Location = new Point(161, 161);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(213, 212);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 9;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(572, 301);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
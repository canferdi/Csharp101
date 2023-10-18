namespace FlightReservationSystem
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(32, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(66, 29);
            label8.Name = "label8";
            label8.Size = new Size(376, 67);
            label8.TabIndex = 0;
            label8.Text = "Can Havayolları";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 151);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(137, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "dd.mm.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(108, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İstanbul", "İzmir", "Ankara", "Adana", "Antalya" });
            comboBox2.Location = new Point(108, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(137, 28);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "İzmir", "Ankara", "Adana", "Antalya" });
            comboBox1.Location = new Point(108, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 28);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 158);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 0;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 119);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 0;
            label3.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(423, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(116, 149);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(116, 107);
            maskedTextBox4.Mask = "(999) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(125, 27);
            maskedTextBox4.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(116, 71);
            maskedTextBox3.Mask = "00000000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 27);
            maskedTextBox3.TabIndex = 3;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(116, 35);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 114);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 2;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 78);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 1;
            label6.Text = "TC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 42);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 0;
            label5.Text = "Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(30, 375);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(752, 124);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(251, 51);
            button2.Name = "button2";
            button2.Size = new Size(49, 38);
            button2.TabIndex = 5;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 512);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Uçuş Rezervasyon Sistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Button button1;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}
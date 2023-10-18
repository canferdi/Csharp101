namespace FlightReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "->" + comboBox2.Text +
                " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text +
                " YOLCU BÝLGÝLERÝ ~ " + " Ad Soyad: " + maskedTextBox2.Text +
                " TC: " + maskedTextBox3.Text + " Telefon No: " + maskedTextBox4.Text);
            MessageBox.Show("Yolcu kaydedildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tempLoc = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = tempLoc;
        }
    }
}
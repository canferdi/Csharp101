namespace NameSurnameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label6.Text = textBox3.Text;
        }

    }
}
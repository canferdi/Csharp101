namespace KDVcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productType;
            int price;
            double kdvRate;

            productType = comboBox1.Text;
            price = Convert.ToInt16(textBox1.Text);
            kdvRate = Convert.ToDouble(comboBox2.Text);

            MessageBox.Show("Ürün: " + productType + "\nÖdenecek tutar: " + price * (1 + kdvRate));
        }
    }
}
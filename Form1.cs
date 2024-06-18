namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_click( object sender, EventArgs e)
        {
            var number1 = Convert.ToInt32(textBox1.Text);
            var number2 = Convert.ToInt32(textBox2.Text);

            var product = number1 + number2;
            label3.Text = product.ToString();

        }
    }
}

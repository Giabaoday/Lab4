namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai4.Form1 form = new Bai4.Form1();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai5.Form1 form = new Bai5.Form1();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai6.Form1 form = new Bai6.Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cau1.Form1 form = new Cau1.Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cau3.Form1 form = new Cau3.Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cau2.Bai2 form = new Cau2.Bai2();
            form.Show();
        }
    }
}

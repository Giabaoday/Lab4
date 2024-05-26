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
    }
}

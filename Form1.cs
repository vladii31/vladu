namespace vladu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            long tal1 = long.Parse(textBox1.Text);
            long tal2 = long.Parse(textBox2.Text);
            long p = tal1 + tal2;
            string k = p.ToString();

            label3.Text = k;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long tal1 = long.Parse(textBox1.Text);
            long tal2 = long.Parse(textBox2.Text);
            long l = tal1 - tal2;
            String k = l.ToString();
            label3.Text=k;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long tal1 = long.Parse(textBox1.Text);
            long tal2 = long.Parse(textBox2.Text);
            long o = tal1 * tal2;
            string k = o.ToString();
            label3.Text = k;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long tal1 = long.Parse(textBox1.Text);
            long tal2 = long.Parse(textBox2.Text);
            long s = tal1 / tal2;
            string k = s.ToString();
            label3.Text = k;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            label3.Text = "";
        }
    }
}
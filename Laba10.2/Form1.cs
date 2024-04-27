namespace _10._2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            int p = Convert.ToInt32(textBox3.Text);
            int sum = 0;
            if (checkBox1.Checked)
            {
                sum = ((2*p+n)*(n+ 1))/2;
            }
            else if (checkBox2.Checked)
            {
                for (int i = 0; i <= n; i++)
                {
                    sum += i+p;
                }
            }
            textBox1.Text = sum.ToString();
        }
    }
}

namespace Lab_11._1
{
    public partial class Form1 : Form
    {
        private double sum;
        private double n;
        public Form1()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sum = 0;
            n = trackBar1.Value;
            textBox1.Text = trackBar1.Value.ToString();
            if (checkBox1.Checked)
            {
                sum = (0.125)*(1-Math.Pow(-1,n)*(1-6*n*n-4*n*n*n));
            }
            else if (checkBox2.Checked)
            {
                for (int i = 1; i <= n; i++)
                {
                    double newN = i;
                    sum += Math.Pow(-1,i)*Math.Pow(newN,3);
                }
            }
            textBox2.Text = sum.ToString();
        }
    }
}
namespace ТЕст_занятие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width;
            double length;
            double height;
            if (double.TryParse(textBoxWidth.Text, out width) && double.TryParse(textBoxHeight.Text, out height)&& double.TryParse(textBoxLength.Text, out length))
            {
                labelResult.Text = ($"Volume v = {width*length*height}");
            }
            else
            {
                MessageBox.Show("enter relevant ");
            }
        }
    }
}

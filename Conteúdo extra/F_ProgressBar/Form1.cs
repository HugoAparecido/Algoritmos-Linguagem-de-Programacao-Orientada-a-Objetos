namespace F_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox1.Text) >= progressBar1.Minimum) & (int.Parse(textBox1.Text) <= progressBar1.Maximum))
                progressBar1.Value = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
                //Thread.Sleep(200);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
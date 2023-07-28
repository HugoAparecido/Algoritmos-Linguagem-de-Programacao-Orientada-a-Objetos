namespace PrimeiroFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Calcular
        {
            public double valor1;
            public double valor2;
            public double resultado;
            public double Soma()
            {
                return this.valor1 + this.valor2;
            }
            public double Subtracao()
            {
                return this.valor1 - this.valor2;
            }
            public double Multiplicacao()
            {
                return this.valor1 * this.valor2;
            }
            public double Divisao()
            {
                return this.valor1 / this.valor2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox1.Text);
            c.valor2 = Convert.ToDouble(textBox2.Text);
            resultado.Text = Convert.ToString(c.Soma());
            MessageBox.Show("Bom dia. Você calculou a soma");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox1.Text);
            c.valor2 = Convert.ToDouble(textBox2.Text);
            resultado.Text = Convert.ToString(c.Subtracao());
            MessageBox.Show("Bom dia. Você calculou a subtração");
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {

            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox1.Text);
            c.valor2 = Convert.ToDouble(textBox2.Text);
            resultado.Text = Convert.ToString(c.Multiplicacao());
            MessageBox.Show("Bom dia. Você calculou a multiplicação");
        }

        private void divisao_Click(object sender, EventArgs e)
        {

            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox1.Text);
            c.valor2 = Convert.ToDouble(textBox2.Text);
            resultado.Text = Convert.ToString(c.Divisao());
            MessageBox.Show("Bom dia. Você calculou a divisão");
        }
    }
}
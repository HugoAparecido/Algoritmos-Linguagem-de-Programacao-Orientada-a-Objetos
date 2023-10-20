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

        private void Button1_Click(object sender, EventArgs e)
        {
            Calcular c = new()
            {
                valor1 = Convert.ToDouble(textBox1.Text),
                valor2 = Convert.ToDouble(textBox2.Text)
            };
            resultado.Text = Convert.ToString(c.Soma());
            conta.Text = "+";
            MessageBox.Show("Bom dia. Você calculou a soma");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            Calcular c = new()
            {
                valor1 = Convert.ToDouble(textBox1.Text),
                valor2 = Convert.ToDouble(textBox2.Text)
            };
            resultado.Text = Convert.ToString(c.Subtracao());
            conta.Text = "-";
            MessageBox.Show("Bom dia. Você calculou a subtração");
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {

            Calcular c = new()
            {
                valor1 = Convert.ToDouble(textBox1.Text),
                valor2 = Convert.ToDouble(textBox2.Text)
            };
            resultado.Text = Convert.ToString(c.Multiplicacao());
            conta.Text = "*";
            MessageBox.Show("Bom dia. Você calculou a multiplicação");
        }

        private void Divisao_Click(object sender, EventArgs e)
        {

            Calcular c = new()
            {
                valor1 = Convert.ToDouble(textBox1.Text),
                valor2 = Convert.ToDouble(textBox2.Text)
            };
            resultado.Text = Convert.ToString(c.Divisao());
            conta.Text = "/";
            MessageBox.Show("Bom dia. Você calculou a divisão");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace NovoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class CalculoIMC
        {
            //atributos da classe
            public double altura;
            public double peso;
            //metodo da classe
            public double IMC()
            {
                return this.peso / (this.altura * this.altura);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CalculoIMC c = new()
            {
                //MessageBox.Show("Texto");
                peso = Convert.ToDouble(textBox1.Text),
                altura = Convert.ToDouble(textBox2.Text)
            };
            textBox3.Text = Convert.ToString(Math.Round(c.IMC(), 2));
            double imc = c.IMC();
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(100);
            }
            if (imc <= 18.5)
            {
                MessageBox.Show("Está abaixo do peso");
            }
            if (imc >= 18.6 && imc <= 24.9)
            {
                pictureBox2.Visible = true;
                MessageBox.Show("Peso ideal!!! Parabéns");
            }
            if (imc >= 25 && imc <= 29.9)
            {
                MessageBox.Show("Levemente acima do peso");
            }
            if (imc >= 30 && imc <= 34.9)
            {
                MessageBox.Show("Obesidade Grau 1");
            }
            if (imc >= 35 && imc <= 39.9)
            {
                MessageBox.Show("Obesidade Grau 2 - Severa");
            }
            if (imc >= 40)
            {
                MessageBox.Show("Obesidade Grau 3 - Mórbida");
                pictureBox3.Visible = true;
            }
        }
    }
}
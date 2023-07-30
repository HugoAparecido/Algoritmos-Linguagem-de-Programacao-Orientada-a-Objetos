namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Pessoa
        {
            public double altura;
            public double peso;
            public double CalcularIMC()
            {
                return this.peso / (this.altura * this.altura);
            }
            public void Classificacao()
            {
                if (this.CalcularIMC() < 18.5)
                {
                    MessageBox.Show("Abaixo do peso normal");
                }
                else if (this.CalcularIMC() <= 24.9)
                {
                    MessageBox.Show("Peso normal");
                }
                else if (this.CalcularIMC() <= 29.9)
                {
                    MessageBox.Show("Excesso de peso");
                }
                else if (this.CalcularIMC() <= 34.9)
                {
                    MessageBox.Show("Obesidade Classe I");
                }
                else if (this.CalcularIMC() <= 39.9)
                {
                    MessageBox.Show("Obesidade Classe II");
                }
                else
                {
                    MessageBox.Show("Obesidade Classe III");
                }
            }
        }
        private void CalcularIMC_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new()
            {
                altura = Convert.ToDouble(altura.Text),
                peso = Convert.ToDouble(peso.Text)
            };
            imc.Text = Convert.ToString(pessoa.CalcularIMC());
            pessoa.Classificacao();
        }
    }
}
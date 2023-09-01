using System.Data;

namespace Ativiade4Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculo.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calculo.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            calculo.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            calculo.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            calculo.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            calculo.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            calculo.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            calculo.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            calculo.Text += "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            calculo.Text += "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            calculo.Text = string.Empty;
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            calculo.Text += "+";
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            calculo.Text += "-";
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            calculo.Text += "*";
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            calculo.Text += "/";
        }

        private void CasaDecimal_Click(object sender, EventArgs e)
        {
            calculo.Text += ",";
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new();
            calculo.Text = calculo.Text.Replace(",", ".");
            calculo.Text = dataTable.Compute(calculo.Text, String.Empty).ToString();
        }

        private void ApagarTudo_Click(object sender, EventArgs e)
        {
            if (calculo.Text.Length > 0)
            {
                string texto = calculo.Text;
                texto = texto[..^1];
                calculo.Text = texto;
            }
        }

        private void CalculadoraCientíficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.ShowDialog();
            this.Hide();
        }
    }
}
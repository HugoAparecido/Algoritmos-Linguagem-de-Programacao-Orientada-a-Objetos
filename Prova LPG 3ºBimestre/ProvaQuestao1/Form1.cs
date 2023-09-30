namespace ProvaQuestao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double valorEmprestimoVar = Convert.ToDouble(valorEmprestimo.Text);
            double taxaDeJuros = (Convert.ToDouble(taxaJuros.Text) / 100);
            int numeroMeses = comboBox1.SelectedIndex + 1;
            double pagamentoMensal = ((valorEmprestimoVar * taxaDeJuros / 12) * Math.Pow(1 + taxaDeJuros / 12, numeroMeses)) / (Math.Pow(1 + taxaDeJuros / 12, numeroMeses) - 1);
            pagMensal.Text = Convert.ToString(Math.Round(pagamentoMensal, 2));
            totalPago.Text = Convert.ToString(Math.Round(pagamentoMensal * numeroMeses, 2));
            totalJuros.Text = Convert.ToString(Math.Round(Convert.ToDouble(totalPago.Text) - valorEmprestimoVar, 2));
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter cliente;
            string caminho = "D:\\cliente.txt";
            cliente = File.CreateText(caminho);
            cliente.WriteLine(nomeCliente.Text);
            cliente.Close();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter dadosEmprestimo;
            string caminho = "D:\\dadosEmprestimo.txt";
            dadosEmprestimo = File.CreateText(caminho);
            dadosEmprestimo.WriteLine("Pagamento Mensal: " + pagMensal.Text);
            dadosEmprestimo.WriteLine("Valor Total Pago: " + totalPago.Text);
            dadosEmprestimo.WriteLine("Total Juros Pago: " + totalJuros.Text);
            dadosEmprestimo.Close();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\dadosEmprestimo.txt";
            File.Delete(caminho);
        }
    }
}
namespace OrdenacaoDeNomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Nomes
        {
            public string? nome1;
            public string? nome2;
            public string? nome3;
            public string? ordenado;
            public void OrdenarOrdemAlfabetica()
            {
                
            }
        }
        private void organizarNomes_Click(object sender, EventArgs e)
        {
            Nomes nomes = new Nomes();
            nomes.nome1 = Convert.ToString(nome1.Text);
            nomes.nome2 = Convert.ToString(nome2.Text);
            nomes.nome3 = Convert.ToString(nome3.Text);
            exibirNomes.Text = Convert.ToString(nomes.ordenado);
        }
    }
}
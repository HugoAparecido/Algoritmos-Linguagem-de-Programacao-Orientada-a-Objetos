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
            public void OrdenarOrdemAlfabetica()
            {
                if (string.Compare(this.nome1, this.nome2) > 0)
                {
                    (this.nome2, this.nome1) = (this.nome1, this.nome2);
                    if (string.Compare(this.nome2, this.nome3) > 0)
                    {
                        (this.nome3, this.nome2) = (this.nome2, this.nome3);
                        if (string.Compare(this.nome1, this.nome2) > 0)
                        {
                            (this.nome2, this.nome1) = (this.nome1, this.nome2);
                        }
                    }
                }
                if (string.Compare(this.nome2, this.nome3) > 0)
                {
                    (this.nome3, this.nome2) = (this.nome2, this.nome3);
                }
                if (string.Compare(this.nome1, this.nome3) > 0)
                {
                    (this.nome3, this.nome1) = (this.nome1, this.nome3);
                }
            }
        }
        private void OrganizarNomes_Click(object sender, EventArgs e)
        {
            Nomes nomes = new()
            {
                nome1 = Convert.ToString(nome1.Text),
                nome2 = Convert.ToString(nome2.Text),
                nome3 = Convert.ToString(nome3.Text)
            };
            nomes.OrdenarOrdemAlfabetica();
            exibirNomes.Items.Clear();
            exibirNomes.Items.Add(nomes.nome1);
            exibirNomes.Items.Add(nomes.nome2);
            exibirNomes.Items.Add(nomes.nome3);
        }
    }
}
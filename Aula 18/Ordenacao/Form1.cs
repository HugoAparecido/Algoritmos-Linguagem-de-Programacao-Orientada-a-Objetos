namespace Ordenacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class OrdenacaoSimples
        {
            public string? nome1;
            public string? nome2;
            public string? nome3;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrdenacaoSimples ord = new()
            {
                nome1 = textBox1.Text,
                nome2 = textBox2.Text,
                nome3 = textBox3.Text
            };
            string? aux;
            int res = String.Compare(ord.nome1, ord.nome2);
            if (res > 0)
            {
                aux = ord.nome1;
                ord.nome1 = ord.nome2;
                ord.nome2 = aux;
            }
        }
    }
}
namespace Login
{
    public partial class TelaLogin : Form
    {
        public string? usuario;
        public string? senha;
        public TelaLogin()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            if (textBox1.Text == usuario && textBox2.Text == senha && textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                TelaSistema form = new();
                form.Show();
                this.Hide();
            }
            else if (textBox1.Text == usuario && textBox2.Text != senha)
            {
                MessageBox.Show("Senha Inválida");
                textBox2.Text = "";
                textBox2.BackColor = SystemColors.ControlDark;
            }
            else if (textBox1.Text != usuario && textBox2.Text == senha)
            {
                MessageBox.Show("Usuário Inválido");
                textBox1.Text = "";
                textBox1.BackColor = SystemColors.ControlDark;
            }
            else
            {
                MessageBox.Show("Usuário e Senha Inválidos");
            }
            if (textBox1.Text == string.Empty && textBox2.Text != string.Empty)
            {
                MessageBox.Show("Não há nenhuma informação no campo Usuário");
            }
            if (textBox2.Text == string.Empty && textBox1.Text != string.Empty)
            {
                MessageBox.Show("Não há nenhuma informação no campo Senha");
            }
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não há nenhuma informação no campo Usuário e no campo Senha");
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            TelaCadastro form3 = new(this);
            form3.Show();
            this.Hide();
        }
    }
}
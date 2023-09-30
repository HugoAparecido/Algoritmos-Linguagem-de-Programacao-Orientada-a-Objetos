namespace ProvaQuestao2Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamWriter usuario;
            string caminhoUsuario = "D:\\usuario.txt";
            usuario = File.CreateText(caminhoUsuario);
            usuario.WriteLine("OPERADOR");
            usuario.Close();
            StreamWriter senha;
            string caminhoSenha = "D:\\senha.txt";
            senha = File.CreateText(caminhoSenha);
            senha.WriteLine("emprestimo2023");
            senha.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader usuario;
            string caminhoUsuario = "D:\\usuario.txt";
            usuario = File.OpenText(caminhoUsuario);
            StreamReader senha;
            string caminhoSenha = "D:\\senha.txt";
            senha = File.OpenText(caminhoSenha);
            string usuarioComp = usuario.ReadLine();
            string senhaComp = senha.ReadLine();
            if (usuarioText.Text == usuarioComp && senhaText.Text == senhaComp)
            {
                MessageBox.Show("Login efetuado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Dados incorretos!!!");
            }
            senha.Close();
            usuario.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (senhaText.UseSystemPasswordChar == true)
            {
                senhaText.UseSystemPasswordChar = false;
            }
            else
            {
                senhaText.UseSystemPasswordChar = true;
            }
        }
    }
}
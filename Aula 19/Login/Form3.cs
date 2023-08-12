namespace Login
{
    public partial class TelaCadastro : Form
    {
        public class Cliente
        {
            public string? nome;
            public string? sobrenome;
            public string? email;
            public string? usuario;
            public string? senha;
            public Cliente(string? nome, string? sobrenome, string? email, string? usuario)
            {
                this.nome = nome;
                this.sobrenome = sobrenome;
                this.email = email;
                this.usuario = usuario;
            }
        }
        readonly TelaLogin telaLogin;
        public TelaCadastro(TelaLogin telaLog)
        {
            InitializeComponent();
            telaLogin = telaLog;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            nomeText.BackColor = Color.White;
            sobrenomeText.BackColor = Color.White;
            emailText.BackColor = Color.White;
            usuarioText.BackColor = Color.White;
            senhaText.BackColor = Color.White;
            confirmarSenhaText.BackColor = Color.White;
            Cliente cliente = new(nomeText.Text, sobrenomeText.Text, emailText.Text, usuarioText.Text);
            if (senhaText.Text != confirmarSenhaText.Text)
            {
                MessageBox.Show("Confirmação de senha incorreta!!");
                confirmarSenhaText.BackColor = Color.Red;
            }
            else
            {
                cliente.senha = senhaText.Text;
            }
            if (cliente.nome != string.Empty && cliente.sobrenome != string.Empty && cliente.email != string.Empty && cliente.usuario != string.Empty && cliente.senha != string.Empty && senhaText.Text == confirmarSenhaText.Text)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
                telaLogin.Show();
                telaLogin.usuario = cliente.usuario;
                telaLogin.senha = cliente.senha;
                this.Close();
            }
            if (cliente.nome == string.Empty)
            {
                MessageBox.Show("Campo Nome vazio!!");
                nomeText.BackColor = Color.Red;
            }
            if (cliente.sobrenome == string.Empty)
            {
                MessageBox.Show("Campo Sobrenome vazio!!");
                sobrenomeText.BackColor = Color.Red;
            }
            if (cliente.email == string.Empty)
            {
                MessageBox.Show("Campo E-mail vazio!!");
                emailText.BackColor = Color.Red;
            }
            if (cliente.usuario == string.Empty)
            {
                MessageBox.Show("Campo Usuário vazio!!");
                usuarioText.BackColor = Color.Red;
            }
            if (cliente.senha == string.Empty)
            {
                MessageBox.Show("Não foi possível cadastrar a senha!!");
                senhaText.BackColor = Color.Red;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (senhaText.UseSystemPasswordChar == false)
            {
                senhaText.UseSystemPasswordChar = true;
            }
            else
            {
                senhaText.UseSystemPasswordChar = false;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (confirmarSenhaText.UseSystemPasswordChar == false)
            {
                confirmarSenhaText.UseSystemPasswordChar = true;
            }
            else
            {
                confirmarSenhaText.UseSystemPasswordChar = false;
            }
        }
    }
}

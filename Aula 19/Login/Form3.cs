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
        TelaLogin telaLogin;
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
            if (senhaText.Text == confirmarSenhaText.Text)
            {
                cliente.senha = senhaText.Text;
            }
            else
            {
                MessageBox.Show("Confirmação de senha incorreta!!");
                confirmarSenhaText.BackColor = Color.Red;
            }
            if (cliente.nome != null && cliente.sobrenome != null && cliente.email != null && cliente.usuario != null && cliente.senha != null)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
                telaLogin.Show();
                telaLogin.usuario = cliente.usuario;
                telaLogin.senha = cliente.senha;
                this.Close();
            }
            if (cliente.nome == null)
            {
                MessageBox.Show("Campo Nome vazio!!");
                nomeText.BackColor = Color.Red;
            }
            if (cliente.sobrenome == null)
            {
                MessageBox.Show("Campo Sobrenome vazio!!");
                sobrenomeText.BackColor = Color.Red;
            }
            if (cliente.email == null)
            {
                MessageBox.Show("Campo E-mail vazio!!");
                emailText.BackColor = Color.Red;
            }
            if (cliente.usuario == null)
            {
                MessageBox.Show("Campo Usuário vazio!!");
                usuarioText.BackColor = Color.Red;
            }
            if (cliente.senha == null)
            {
                MessageBox.Show("Não foi possível cadastrar a senha!!");
                senhaText.BackColor = Color.Red;
            }
        }
    }
}

using MySql.Data.MySqlClient;

namespace ConexaoBDMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=test";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexão Ok");
                var comando = new MySqlCommand("SELECT * FROM pessoa", conexao);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show($"{reader["id"]} => {reader["nome"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar ao BD: " + ex.Message);
            }
        }
    }
}
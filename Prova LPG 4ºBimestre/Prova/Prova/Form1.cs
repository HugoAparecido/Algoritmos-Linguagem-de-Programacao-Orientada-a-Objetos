using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Cliente
        {
            private string nome { get; set; }
            private string tipo_animal { get; set; }
            private string nome_animal { get; set; }
            private string telefone { get; set; }
            private string endereco { get; set; }
            private string cpf { get; set; }
            public Cliente(string nome, string tipo_animal, string nome_animal, string telefone, string endereco, string cpf)
            {
                this.nome = nome;
                this.tipo_animal = tipo_animal;
                this.nome_animal = nome_animal;
                this.telefone = telefone;
                this.endereco = endereco;
                this.cpf = cpf;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO cliente(`nome`, `tipo_animal`, `nome_animal`, `telefone`,`endereco`, `cpf`) VALUES ('" + this.nome + "', '" + this.tipo_animal + "', '" + this.nome_animal + "', '" + this.telefone + "', '" + this.endereco + "', '" + this.cpf + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Usuário cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public class Produto
        {
            private string nome { get; set; }
            private decimal preco { get; set; }
            private int quantidade { get; set; }
            public Produto(string nome, decimal preco, int quantidade)
            {
                this.nome = nome;
                this.preco = preco;
                this.quantidade = quantidade;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO produto(`nome`, `preco`, `quantidade`) VALUES ('" + this.nome + "', '" + this.preco + "', '" + this.quantidade + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Produto cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public class Servico
        {
            private string nome { get; set; }
            private double preco { get; set; }
            public Servico(string nome, double preco)
            {
                this.nome = nome;
                this.preco = preco;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO servico(`nome`, `preco`) VALUES ('" + this.nome + "', '" + this.preco + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Servico cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        class Usuario
        {
            public string usuario { get; protected set; }
            public string senha {get; protected set; }
            private string tipo;
            public string Tipo 
            {
                get { return this.tipo; }
                set { this.tipo = value; }
            }
            public virtual void Cadastrar() {
                MessageBox.Show("Precisa-se ser um usuário específico para Cadastar");
            }
        }
        class Admin : Usuario
        {
            public Admin(string usuario, string senha, string tipo)
            {
                this.usuario = usuario;
                this.senha = senha;
                this.Tipo = tipo;

            }
            public override void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO usuario(`usuario`, `senha`, `tipo`) VALUES ('" + this.usuario + "', '" + this.senha + "', '" + this.Tipo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Administrador cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        class Vendedor : Usuario
        {
            public Vendedor(string usuario, string senha, string tipo)
            {
                this.usuario = usuario;
                this.senha = senha;
                this.Tipo = tipo;

            }
            public override void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO usuario(`usuario`, `senha`, `tipo`) VALUES ('" + this.usuario + "', '" + this.senha + "', '" + this.Tipo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Vendedor cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        class Veterinario : Usuario
        {
            public Veterinario(string usuario, string senha, string tipo)
            {
                this.usuario = usuario;
                this.senha = senha;
                this.Tipo = tipo;

            }
            public override void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
                string query = "INSERT INTO usuario(`usuario`, `senha`, `tipo`) VALUES ('" + this.usuario + "', '" + this.senha + "', '" + this.Tipo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Veterinário cadastrado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Administrador")
            {
                Admin admin = new Admin(textBox1.Text, textBox2.Text, comboBox1.Text);
                admin.Cadastrar();
            }
            else if (comboBox1.Text == "Vendedor")
            {
                Vendedor vendedor = new Vendedor(textBox1.Text, textBox2.Text, comboBox1.Text);
                vendedor.Cadastrar();
            }
            else if (comboBox1.Text == "Veterinário")
            {
                Veterinario veterinario = new Veterinario(textBox1.Text, textBox2.Text, comboBox1.Text);
                veterinario.Cadastrar();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário");
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
namespace ExercicioNotaFiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Produto
        {
            public string item;
            public int quantidade;
            public double preco;
            private double valorTotal;
            public double ValorTotal
            {
                get { return this.valorTotal; }
                set { this.valorTotal = value; }
            }
            public void CalcularTotal()
            {
                this.valorTotal =  this.quantidade * this.preco;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Botão Cadastrar
            Produto produto = new Produto();
            produto.item = textBox1.Text;
            produto.quantidade = Convert.ToInt32(textBox2.Text);
            produto.preco = Convert.ToDouble(textBox3.Text);
            produto.CalcularTotal();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=exercicio_nota_fiscal;";
            string query = "INSERT INTO produto(`Item`, `quantidade`, `preco`, `valor_total`) VALUES ('" + produto.item + "', '" + produto.quantidade + "', '" + produto.preco + "', '" + produto.ValorTotal + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Produto Cadastrado com sucesso!!");
                textBox4.Text = produto.ValorTotal.ToString();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }
    }
}

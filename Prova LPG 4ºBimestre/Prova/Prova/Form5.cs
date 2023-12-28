using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        abstract class Pagamento
        {
            public abstract double TotalAPagar(double valorItem, int quantidade);
        }
        class AVista : Pagamento
        {
            public override double TotalAPagar(double valorItem, int quantidade)
            {
                return (valorItem * quantidade) - ((valorItem * quantidade)*0.05);
            }
        }
        class APrazo : Pagamento
        {
            public override double TotalAPagar(double valorItem, int quantidade)
            {
                return valorItem * quantidade;
            }
        }
        private void voltarParaPáginaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
            string query = "SELECT nome FROM produto";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0) };
                        comboBox1.Items.Add(row[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Não existem registros no banco");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "A vista")
            {
                AVista aVista = new AVista();
                textBox2.Text = Convert.ToString(aVista.TotalAPagar(Convert.ToDouble(textBox1.Text), Convert.ToInt32(numericUpDown1.Value)));
            }
            if (comboBox2.Text == "A prazo")
            {
                APrazo aPrazo = new APrazo();
                textBox2.Text = Convert.ToString(aPrazo.TotalAPagar(Convert.ToDouble(textBox1.Text), Convert.ToInt32(numericUpDown1.Value)));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pet_shop;";
            string query = "SELECT preco FROM produto WHERE nome = '"+ comboBox1.Text +"'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0) };
                        textBox1.Text += row[0];
                    }
                }
                else
                {
                    MessageBox.Show("Não existem registros no banco");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

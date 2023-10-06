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

namespace trabalho0610
{
    public partial class Form2 : Form
    {
        readonly Form1 form1;
        readonly Form3 form3;
        public Form2(Form1 form11, Form3 form33)
        {
            InitializeComponent();
            form1 = form11;
            form3 = form33;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double media;
            media = ((Convert.ToDouble(textBox8.Text)+ Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox12.Text) + Convert.ToDouble(textBox11.Text)) /4);
            textBox10.Text = Convert.ToString(media);
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
            string query = "INSERT INTO aluno(`ra`, `nome`, `cpf`, `curso`,`email`, `endereco`, `telefone`, `nota_Bim1`, `nota_Bim2`, `nota_Bim3`, `nota_Bim4`, `media`) VALUES ('" + textBox2.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox12.Text + "', '" + textBox11.Text + "', '" + textBox10.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Aluno cadastrado com sucesso!!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(null, this);
            form3.Show();
            this.Close();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

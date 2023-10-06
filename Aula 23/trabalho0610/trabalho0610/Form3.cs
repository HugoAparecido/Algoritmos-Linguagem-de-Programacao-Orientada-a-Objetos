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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trabalho0610
{
    public partial class Form3 : Form
    {
        readonly Form1 form1;
        readonly Form2 form2;
        public Form3(Form1 form11, Form2 form22)
        {
            InitializeComponent();
            form1 = form11;
            form2 = form22;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(null, this);
            form2.Show();
            this.Close();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
            string query = "INSERT INTO curso(`nome`, `codigo`, `cargaHoraria`, `periodo`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Curso cadastrado com sucesso!!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

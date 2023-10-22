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
        class Curso
        {
            private string nome;
            private int codigo;
            private int cargaHoraria;
            private string periodo;
            public Curso(string nome, int codigo, int cargaHoraria, string periodo)
            {
                this.nome = nome;
                this.codigo = codigo;
                this.cargaHoraria = cargaHoraria;
                this.periodo = periodo;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
                string query = "INSERT INTO curso(`nome`, `codigo`, `cargaHoraria`, `periodo`) VALUES ('" + this.nome + "', '" + this.codigo + "', '" + this.cargaHoraria + "', '" + this.periodo + "')";
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
            public void Atualizar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
                string query = "UPDATE curso set `nome` = '" + this.nome + "', `cargaHoraria` = '" + this.cargaHoraria + "', `periodo` = '" + this.periodo + "' WHERE codigo = '" + this.codigo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Dados do Curso atualizados com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void Deletar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
                string query = "DELETE FROM curso WHERE codigo = '" + this.codigo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Curso Deletado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        readonly Form1 form1;
        readonly Form2 form2;
        System.Windows.Forms.ListView.SelectedListViewItemCollection selecionado;
        public Form3(Form1 form11, Form2 form22, System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados)
        {
            InitializeComponent();
            form1 = form11;
            form2 = form22;
            selecionado = itens_selecionados;
            if (selecionado != null)
            {
                foreach (ListViewItem item in selecionado)
                {
                    textBox2.Text = item.SubItems[0].Text;
                    textBox1.Text = item.SubItems[1].Text;
                    textBox3.Text = item.SubItems[2].Text;
                    textBox4.Text = item.SubItems[3].Text;
                    textBox2.Enabled = false;
                }
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(null, this, null);
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
            Curso curso = new Curso(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text);
            curso.Cadastrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text);
            curso.Deletar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text);
            curso.Atualizar();
        }
    }
}

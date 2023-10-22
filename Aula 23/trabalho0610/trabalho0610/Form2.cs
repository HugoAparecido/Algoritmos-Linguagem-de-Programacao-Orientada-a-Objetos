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
    public partial class Form2 : Form
    {
        class Aluno
        {
            private string ra;
            private string nome;
            private string cpf;
            private string curso;
            private string email;
            private string endereco;
            private string telefone;
            private double nota_Bim1;
            private double nota_Bim2;
            private double nota_Bim3;
            private double nota_Bim4;
            public double media;
            private void Media()
            {
                this.media = ((this.nota_Bim1 + this.nota_Bim2 + this.nota_Bim3 + this.nota_Bim4) / 4);
            }
            public Aluno(string ra, string nome, string cpf, string curso, string email, string endereco, string telefone, double nota_Bim1, double nota_Bim2, double nota_Bim3, double nota_Bim4)
            {
                this.ra = ra;
                this.nome = nome;
                this.cpf = cpf;
                this.curso = curso;
                this.email = email;
                this.endereco = endereco;
                this.telefone = telefone;
                this.nota_Bim1 = nota_Bim1;
                this.nota_Bim2 = nota_Bim2;
                this.nota_Bim3 = nota_Bim3;
                this.nota_Bim4 = nota_Bim4;
                this.Media();
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
                string query = "INSERT INTO aluno(`ra`, `nome`, `cpf`, `curso`,`email`, `endereco`, `telefone`, `nota_Bim1`, `nota_Bim2`, `nota_Bim3`, `nota_Bim4`, `media`) VALUES ('" + this.ra + "', '" + this.nome + "', '" + this.cpf + "', '" + this.curso + "', '" + this.email + "', '" + this.endereco + "', '" + this.telefone + "', '" + this.nota_Bim1 + "', '" + this.nota_Bim2 + "', '" + this.nota_Bim3 + "', '" + this.nota_Bim4 + "', '" + this.media + "')";
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
            public void Atualizar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
                string query = "UPDATE aluno set `nome` = '" + this.nome + "', `cpf` = '" + this.cpf + "', `curso` = '" + this.curso + "', `email` = '" + this.email + "', `endereco` = '" + this.endereco + "', `telefone` = '" + this.telefone + "', `nota_Bim1` = '" + this.nota_Bim1 + "', `nota_Bim2` = '" + this.nota_Bim2 + "', `nota_Bim3` = '" + this.nota_Bim3 + "', `nota_Bim4` = '" + this.nota_Bim4 + "', `media` = '" + this.media + "' WHERE ra = '" + this.ra + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Dados do Aluno atualizados com sucesso!!");
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
                string query = "DELETE FROM aluno WHERE ra = '" + this.ra + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Aluno Deletado com sucesso!!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        readonly Form1 form1;
        readonly Form3 form3;
        System.Windows.Forms.ListView.SelectedListViewItemCollection selecionado;
        public Form2(Form1 form11, Form3 form33, System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados)
        {
            InitializeComponent();
            form1 = form11;
            form3 = form33;
            selecionado = itens_selecionados;
            if (selecionado != null )
            {
                foreach (ListViewItem item in selecionado)
                {
                    textBox2.Text = item.SubItems[0].Text;
                    textBox1.Text = item.SubItems[1].Text;
                    textBox3.Text = item.SubItems[2].Text;
                    textBox5.Text = item.SubItems[3].Text;
                    textBox4.Text = item.SubItems[4].Text;
                    textBox7.Text = item.SubItems[5].Text;
                    textBox6.Text = item.SubItems[6].Text;
                    textBox8.Text = item.SubItems[7].Text;
                    textBox9.Text = item.SubItems[8].Text;
                    textBox12.Text = item.SubItems[9].Text;
                    textBox11.Text = item.SubItems[10].Text;
                    textBox10.Text = item.SubItems[11].Text;
                    textBox2.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox12.Text), Convert.ToDouble(textBox11.Text));
            textBox10.Text = Convert.ToString(aluno.media);
            aluno.Cadastrar();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(null, this, null);
            form3.Show();
            this.Close();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox12.Text), Convert.ToDouble(textBox11.Text));
            textBox10.Text = Convert.ToString(aluno.media);
            aluno.Deletar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Aluno aluno = new Aluno(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox12.Text), Convert.ToDouble(textBox11.Text));
            textBox10.Text = Convert.ToString(aluno.media);
            aluno.Atualizar();
        }
    }
}

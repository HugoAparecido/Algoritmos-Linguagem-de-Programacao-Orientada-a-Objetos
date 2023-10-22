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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("RA", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ENDERECO", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("TELEFONE", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("EMAIL", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CURSO", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOTA_BIM1", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOTA_BIM2", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOTA_BIM3", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOTA_BIM4", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("MEDIA", 100, HorizontalAlignment.Left);
            listView2.View = View.Details;
            listView2.LabelEdit = true;
            listView2.AllowColumnReorder = true;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Columns.Add("CODIGO", 130, HorizontalAlignment.Left);
            listView2.Columns.Add("CURSO", 130, HorizontalAlignment.Left);
            listView2.Columns.Add("CARGAHORARIA", 130, HorizontalAlignment.Left);
            listView2.Columns.Add("PERIODO", 130, HorizontalAlignment.Left);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
            string query = "SELECT * FROM aluno WHERE nome LIKE '%" + textBox1.Text + "%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
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

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, null, null);
            form2.Show();
            this.Hide();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this, null, null);
            form3.Show();
            this.Hide();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar;";
            string query = "SELECT * FROM curso WHERE nome LIKE '%" + textBox2.Text + "%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    listView2.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView2.Items.Add(listViewItem);
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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados = listView2.SelectedItems;
            Form3 form3 = new Form3(this, null, itens_selecionados);
            form3.Show();
            this.Hide();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados = listView1.SelectedItems;
            Form2 form2 = new Form2(this, null, itens_selecionados);
            form2.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppBanco
{
    public partial class Form1 : Form
    {
        private int ?id_selecionado = null;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("EMAIL", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("TELEFONE", 100, HorizontalAlignment.Left); 
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Botão Cadastrar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=banco;";
            string query = "INSERT INTO usuario(`id`, `nome`, `cpf`, `email`, `telefone`) VALUES (NULL, '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Usuário Cadastrado com sucesso!!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Botão Pesquisar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=banco;";
            //string query = "SELECT * FROM usuario";
            string query = "SELECT * FROM usuario WHERE nome LIKE '%" + textBox6.Text + "%'";
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
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
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

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados = listView1.SelectedItems;
            foreach (ListViewItem item in itens_selecionados)
            {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[4].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botão Atualizar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=banco;";
            string query = "UPDATE `usuario` SET `nome` = '" + textBox2.Text + "', `cpf` = '" + textBox3.Text + "', `email` = '" + textBox4.Text + "', `telefone` = '" + textBox5.Text + "' WHERE id = '" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Usuário Atualizado com sucesso!!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botão Deletar-Apagar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=banco;";
            string query = "DELETE FROM `usuario` WHERE id = '" + textBox1.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
            {
                CommandTimeout = 60
            };
            try
            {
                DialogResult res = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Absoluta?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Usuário Removido com sucesso!!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}

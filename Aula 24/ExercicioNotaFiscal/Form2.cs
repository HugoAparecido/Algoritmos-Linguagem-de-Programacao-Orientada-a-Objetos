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

namespace ExercicioNotaFiscal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Item", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantidade", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Preço", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Total", 150, HorizontalAlignment.Left);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString();
            label5.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão Pesquisar
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=exercicio_nota_fiscal;";
            //string query = "SELECT * FROM usuario";
            string query = "SELECT * FROM produto";
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

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CadAlunoCurso
{
    public partial class FormCadastrarAluno : Form
    {
        readonly FormPesquisa formPesquisaLocal;
        readonly System.Windows.Forms.ListView.SelectedListViewItemCollection selecionado;
        public FormCadastrarAluno(FormPesquisa formPesquisa, System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados)
        {
            InitializeComponent();
            formPesquisaLocal = formPesquisa;
            selecionado = itens_selecionados;
            if (selecionado != null)
            {
                foreach (ListViewItem item in selecionado)
                {
                    caixaInsercaoRA.Text = item.SubItems[0].Text;
                    caixaInsercaoNome.Text = item.SubItems[1].Text;
                    caixaInsercaoCPF.Text = item.SubItems[2].Text;
                    caixaInsercaoEndereco.Text = item.SubItems[3].Text;
                    caixaInsercaoTelefone.Text = item.SubItems[4].Text;
                    caixaInsercaoEmail.Text = item.SubItems[5].Text;
                    escolherCurso.Text = item.SubItems[6].Text;
                    caixaInsercaoNotaBim1.Text = item.SubItems[7].Text;
                    caixaInsercaoNotaBim2.Text = item.SubItems[8].Text;
                    caixaInsercaoNotaBim3.Text = item.SubItems[9].Text;
                    caixaInsercaoNotaBim4.Text = item.SubItems[10].Text;
                    caixaMostrarMedia.Text = item.SubItems[11].Text;
                    caixaInsercaoRA.Enabled = false;
                }
            }
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formPesquisaLocal.Show();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = control as System.Windows.Forms.TextBox;
                    textBox.Clear();
                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = control as System.Windows.Forms.ComboBox;
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private void CursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastroCurso formCadastroCurso = new FormCadastroCurso(formPesquisaLocal, null);
            formCadastroCurso.ShowDialog();
        }

        private void CadastarAluno_Click(object sender, EventArgs e)
        {
            string texto = escolherCurso.SelectedItem.ToString();
            string capturar_codigo = texto.Substring(0, 1);
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, Convert.ToInt32(capturar_codigo), caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Cadastrar();
            caixaMostrarMedia.Text = Convert.ToString(aluno.Media());
        }

        private void AtualizarAluno_Click(object sender, EventArgs e)
        {
            string texto = escolherCurso.SelectedItem.ToString();
            string capturar_codigo = texto.Substring(0, 1);
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, Convert.ToInt32(capturar_codigo), caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Atualizar();
        }

        private void DeletarAluno_Click(object sender, EventArgs e)
        {
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, 0, caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Deletar();
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = control as System.Windows.Forms.TextBox;
                    textBox.Clear();
                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = control as System.Windows.Forms.ComboBox;
                    comboBox.SelectedIndex = -1;
                }
                else if(control is System.Windows.Forms.MaskedTextBox)
                {
                    System.Windows.Forms.MaskedTextBox maskedTextBox = control as System.Windows.Forms.MaskedTextBox;
                    maskedTextBox.Clear();
                }
            }
        }

        private void FormCadastrarAluno_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
            string query = "SELECT codigo_curso, nome_curso FROM curso";
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
                        string[] row = { reader.GetString(0), reader.GetString(1) };
                        escolherCurso.Items.Add(row[0] + " " + row[1]);
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
    }
}

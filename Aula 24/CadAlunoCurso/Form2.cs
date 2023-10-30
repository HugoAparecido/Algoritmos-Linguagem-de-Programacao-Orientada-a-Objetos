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
                    escolherCurso.Text = item.SubItems[3].Text;
                    caixaInsercaoEmail.Text = item.SubItems[4].Text;
                    caixaInsercaoEndereco.Text = item.SubItems[5].Text;
                    caixaInsercaoTelefone.Text = item.SubItems[6].Text;
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
            formPesquisaLocal.ShowDialog();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void CursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastroCurso formCadastroCurso = new FormCadastroCurso(formPesquisaLocal, null);
            formCadastroCurso.ShowDialog();
        }

        private void CadastarAluno_Click(object sender, EventArgs e)
        {
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, Convert.ToInt32(escolherCurso.SelectedIndex), caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Cadastrar();
        }

        private void AtualizarAluno_Click(object sender, EventArgs e)
        {
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, Convert.ToInt32(escolherCurso.SelectedIndex), caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Atualizar();
        }

        private void DeletarAluno_Click(object sender, EventArgs e)
        {
            FormPesquisa.Aluno aluno = new FormPesquisa.Aluno(caixaInsercaoRA.Text, caixaInsercaoNome.Text, caixaInsercaoCPF.Text, Convert.ToInt32(escolherCurso.SelectedIndex), caixaInsercaoEmail.Text, caixaInsercaoEndereco.Text, caixaInsercaoTelefone.Text, Convert.ToDouble(caixaInsercaoNotaBim1.Text), Convert.ToDouble(caixaInsercaoNotaBim2.Text), Convert.ToDouble(caixaInsercaoNotaBim3.Text), Convert.ToDouble(caixaInsercaoNotaBim4.Text));
            aluno.Deletar();
        }

        private void FormCadastrarAluno_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
            string query = "SELECT nome_curso, codigo_curso FROM curso";
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
                    escolherCurso.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1) };
                        escolherCurso.Items.Add(row[0]);
                        escolherCurso.Items.IndexOf(row[1]);
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

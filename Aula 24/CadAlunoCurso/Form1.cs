using MySql.Data.MySqlClient;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace CadAlunoCurso
{
    public partial class FormPesquisa : Form
    {
        public class Aluno
        {
            private readonly string ra;
            private readonly string nome;
            private readonly string cpf;
            private readonly string email;
            private readonly string endereco;
            private readonly string telefone;
            private readonly double nota_Bim1;
            private readonly double nota_Bim2;
            private readonly double nota_Bim3;
            private readonly double nota_Bim4;
            private readonly double media;
            private readonly int codigo_curso;
            public double Media()
            {
                return ((this.nota_Bim1 + this.nota_Bim2 + this.nota_Bim3 + this.nota_Bim4) / 4);
            }
            public Aluno(string ra, string nome, string cpf, int curso, string email, string endereco, string telefone, double nota_Bim1, double nota_Bim2, double nota_Bim3, double nota_Bim4)
            {
                this.ra = ra;
                this.nome = nome;
                this.cpf = cpf;
                this.email = email;
                this.endereco = endereco;
                this.telefone = telefone;
                this.nota_Bim1 = nota_Bim1;
                this.nota_Bim2 = nota_Bim2;
                this.nota_Bim3 = nota_Bim3;
                this.nota_Bim4 = nota_Bim4;
                this.media = this.Media();
                this.codigo_curso = curso;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "INSERT INTO aluno(`ra_aluno`, `nome_aluno`, `cpf_aluno`, `codigo_curso`,`email`, `endereco`, `telefone`, `nota_Bim_1`, `nota_Bim_2`, `nota_Bim_3`, `nota_Bim_4`, `media`) VALUES ('" + this.ra + "', '" + this.nome + "', '" + this.cpf + "', '" + this.codigo_curso + "', '" + this.email + "', '" + this.endereco + "', '" + this.telefone + "', '" + this.nota_Bim1 + "', '" + this.nota_Bim2 + "', '" + this.nota_Bim3 + "', '" + this.nota_Bim4 + "', '" + this.media + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
            public void Pesquisar(string caixaPesquisa, System.Windows.Forms.ListView visualizacaoAluno)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "SELECT a.ra_aluno, a.nome_aluno, a.cpf_aluno, a.endereco, a.telefone, a.email, c.nome_curso, a.nota_bim_1, a.nota_bim_2, a.nota_bim_3, a.nota_bim_4, a.media FROM aluno a INNER JOIN curso c ON a.codigo_curso = c.codigo_curso WHERE a.nome_aluno LIKE '%" + caixaPesquisa + "%'";
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
                        visualizacaoAluno.Items.Clear();
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11) };
                            var listViewItem = new ListViewItem(row);
                            visualizacaoAluno.Items.Add(listViewItem);
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
            public void Atualizar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "UPDATE aluno set `nome_aluno` = '" + this.nome + "', `cpf_aluno` = '" + this.cpf + "', `codigo_curso` = '" + this.codigo_curso + "', `email` = '" + this.email + "', `endereco` = '" + this.endereco + "', `telefone` = '" + this.telefone + "', `nota_Bim_1` = '" + this.nota_Bim1 + "', `nota_Bim_2` = '" + this.nota_Bim2 + "', `nota_Bim_3` = '" + this.nota_Bim3 + "', `nota_Bim_4` = '" + this.nota_Bim4 + "', `media` = '" + this.media + "' WHERE ra_aluno = '" + this.ra + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "DELETE FROM aluno WHERE ra_aluno = '" + this.ra + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
        public class Curso
        {
            private readonly string nome;
            public int codigo;
            private readonly int cargaHoraria;
            private readonly string periodo;
            public Curso(string nome, int codigo, int cargaHoraria, string periodo)
            {
                this.nome = nome;
                this.codigo = codigo;
                this.cargaHoraria = cargaHoraria;
                this.periodo = periodo;
            }
            public void Cadastrar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "INSERT INTO curso(`nome_curso`, `cargaHoraria`, `periodo`) VALUES ('" + this.nome + "', '" + this.cargaHoraria + "', '" + this.periodo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
            public void Pesquisar(string caixaPesquisa, System.Windows.Forms.ListView visualizacaoCurso)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "SELECT * FROM curso WHERE nome_curso LIKE '%" + caixaPesquisa + "%'";
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
                        visualizacaoCurso.Items.Clear();
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                            var listViewItem = new ListViewItem(row);
                            visualizacaoCurso.Items.Add(listViewItem);
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
            public void Atualizar()
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "UPDATE curso set `nome_curso` = '" + this.nome + "', `cargaHoraria` = '" + this.cargaHoraria + "', `periodo` = '" + this.periodo + "' WHERE codigo_curso = '" + this.codigo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cadastro_escolar_2;";
                string query = "DELETE FROM curso WHERE codigo_curso = '" + this.codigo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection)
                {
                    CommandTimeout = 60
                };
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
        public FormPesquisa()
        {
            InitializeComponent();
            visualizacaoAluno.View = View.Details;
            visualizacaoAluno.LabelEdit = true;
            visualizacaoAluno.AllowColumnReorder = true;
            visualizacaoAluno.FullRowSelect = true;
            visualizacaoAluno.GridLines = true;
            visualizacaoAluno.Columns.Add("RA", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("NOME", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("ENDERECO", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("TELEFONE", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("EMAIL", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("CURSO", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("NOTA_BIM1", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("NOTA_BIM2", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("NOTA_BIM3", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("NOTA_BIM4", 100, HorizontalAlignment.Left);
            visualizacaoAluno.Columns.Add("MEDIA", 100, HorizontalAlignment.Left);
            visualizacaoCurso.View = View.Details;
            visualizacaoCurso.LabelEdit = true;
            visualizacaoCurso.AllowColumnReorder = true;
            visualizacaoCurso.FullRowSelect = true;
            visualizacaoCurso.GridLines = true;
            visualizacaoCurso.Columns.Add("CODIGO", 130, HorizontalAlignment.Left);
            visualizacaoCurso.Columns.Add("CURSO", 130, HorizontalAlignment.Left);
            visualizacaoCurso.Columns.Add("CARGAHORARIA", 130, HorizontalAlignment.Left);
            visualizacaoCurso.Columns.Add("PERIODO", 130, HorizontalAlignment.Left);
        }

        private void BuscarAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(null, null, null, 0, null, null, null, 0, 0, 0, 0);
            aluno.Pesquisar(caixaPesquisaAluno.Text, visualizacaoAluno);
        }

        private void PesquisarCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(null, 0, 0, null);
            curso.Pesquisar(caixaPesquisaCurso.Text, visualizacaoCurso);
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastrarAluno cadastrarAluno = new FormCadastrarAluno(this, null);
            cadastrarAluno.ShowDialog();
        }

        private void CursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastroCurso formCadastroCurso = new FormCadastroCurso(this, null);
            formCadastroCurso.ShowDialog();
        }

        private void VisualizacaoAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.ListView.SelectedListViewItemCollection selectedListViewItemCollection = visualizacaoAluno.SelectedItems;
            FormCadastrarAluno formCadastrarAluno = new FormCadastrarAluno(this, selectedListViewItemCollection);
            formCadastrarAluno.ShowDialog();
        }

        private void VisualizacaoCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.ListView.SelectedListViewItemCollection selectedListViewItemCollection = visualizacaoCurso.SelectedItems;
            FormCadastroCurso formCadastroCurso = new FormCadastroCurso(this, selectedListViewItemCollection);
            formCadastroCurso.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;

namespace CadAlunoCurso
{
    public partial class FormCadastroCurso : Form
    {
        readonly FormPesquisa formPesquisaLocal;
        readonly FormCadastrarAluno cadastrarAlunoLocal;
        readonly System.Windows.Forms.ListView.SelectedListViewItemCollection selecionado;
        public FormCadastroCurso(FormPesquisa formPesquisa, System.Windows.Forms.ListView.SelectedListViewItemCollection itens_selecionados)
        {
            InitializeComponent();
            formPesquisaLocal = formPesquisa;
            selecionado = itens_selecionados;
            if (selecionado != null)
            {
                foreach (ListViewItem item in selecionado)
                {
                    caixaMostrarCodigo.Text = item.SubItems[0].Text;
                    caixaInserirNomeCurso.Text = item.SubItems[1].Text;
                    caixaInserirCargaHoraria.Text = item.SubItems[2].Text;
                    escolherPeriodo.Text = item.SubItems[3].Text;
                    caixaMostrarCodigo.Enabled = false;
                }
            }
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formPesquisaLocal.Show();
        }

        private void CadastrarCurso_Click(object sender, EventArgs e)
        {
            FormPesquisa.Curso curso = new FormPesquisa.Curso(caixaInserirNomeCurso.Text, 0, Convert.ToInt32(caixaInserirCargaHoraria.Text), escolherPeriodo.Text);
            curso.Cadastrar();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCadastrarAluno formCadastrarAluno = new FormCadastrarAluno(formPesquisaLocal, null);
            formCadastrarAluno.ShowDialog();
        }

        private void CursoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AtualizarCurso_Click(object sender, EventArgs e)
        {
            FormPesquisa.Curso curso = new FormPesquisa.Curso(caixaInserirNomeCurso.Text, Convert.ToInt32(caixaMostrarCodigo.Text), Convert.ToInt32(caixaInserirCargaHoraria.Text), escolherPeriodo.Text);
            curso.Atualizar();
        }

        private void DeletarCurso_Click(object sender, EventArgs e)
        {
            FormPesquisa.Curso curso = new FormPesquisa.Curso(caixaInserirNomeCurso.Text, Convert.ToInt32(caixaMostrarCodigo.Text), Convert.ToInt32(caixaInserirCargaHoraria.Text), escolherPeriodo.Text);
            curso.Deletar(); 
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
    }
}

namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalvarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter texto1;
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\Hugo.txt";
            texto1 = File.CreateText(caminho);
            texto1.WriteLine(richTextBox1.Text);
            texto1.Close();
        }

        private void AbrirLocalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            listBox1.Visible = true;
            StreamReader texto2;
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\Hugo.txt";
            texto2 = File.OpenText(caminho);
            while (texto2.EndOfStream != true)
            {
                string textoLido = texto2.ReadLine();
                listBox1.Items.Add(textoLido);
            }
            texto2.Close();
        }

        private void abrirComONotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\Hugo.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        private void deletarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\Hugo.txt";
            File.Delete(caminho);
            richTextBox1.Visible = true;
            listBox1.Visible = false;
            richTextBox1.Text = "";
        }
    }
}
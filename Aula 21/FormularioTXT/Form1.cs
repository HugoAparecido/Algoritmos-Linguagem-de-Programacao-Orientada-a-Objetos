using System.IO;
namespace FormularioTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter texto1;
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\fenascachorra.txt";
            texto1 = File.CreateText(caminho);
            texto1.WriteLine(richTextBox1.Text);
            texto1.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StreamReader texto2;
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\fenascachorra.txt";
            texto2 = File.OpenText(caminho);
            while (texto2.EndOfStream != true)
            {
                string textoLido = texto2.ReadLine();
                listBox1.Items.Add(textoLido);
            }
            texto2.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\fenascachorra.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Atividades de programação e desenvolvimento feitos no Instituto Federal\\Algoritmos-Linguagem-de-Programa--o-Orientada-a-Objetos\\Aula 21\\fenascachorra.txt";
            File.Delete(caminho);
        }
    }
}
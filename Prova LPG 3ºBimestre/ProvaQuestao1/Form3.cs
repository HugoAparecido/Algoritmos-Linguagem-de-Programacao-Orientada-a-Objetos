using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaQuestao1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            StreamReader cliente;
            string caminhoCli = "D:\\cliente.txt";
            cliente = File.OpenText(caminhoCli);
            string clienteLido = cliente.ReadLine();
            listaClientes.Items.Add(clienteLido);
            cliente.Close();
            StreamReader dadosEmprestimoVar;
            string caminho = "D:\\dadosEmprestimo.txt";
            dadosEmprestimoVar = File.OpenText(caminho);
            while (dadosEmprestimoVar.EndOfStream != true)
            {
                string dadosEmpretimoLido = dadosEmprestimoVar.ReadLine();
                dadosEmprestimo.Items.Add(dadosEmpretimoLido);
            }
            dadosEmprestimoVar.Close();
        }
    }
}

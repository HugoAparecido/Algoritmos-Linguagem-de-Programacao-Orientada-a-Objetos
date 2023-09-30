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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            StreamReader cliente;
            string caminho = "D:\\cliente.txt";
            cliente = File.OpenText(caminho);
            while(cliente.EndOfStream!=true)
            {
                string clienteLido = cliente.ReadLine();
                listaClientes.Items.Add(clienteLido);
            }
            cliente.Close();
        }
    }
}

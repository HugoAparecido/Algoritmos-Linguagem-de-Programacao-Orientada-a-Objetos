using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormContaBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Conta
        {
            // Atributos da classe
            public string titular = "";
            public int numeroConta = 0;
            private double saldoConta = 0;
            // Propriedades da variável saldo
            public double SaldoConta
            {
                get { return this.saldoConta; }
                set { this.saldoConta = value; }
            }
            // Métodos da classe
            public void Depositar(double valor)
            {
                this.saldoConta += valor;
            }
            public void Sacar(double valor)
            {
                this.saldoConta -= valor;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.SaldoConta = Convert.ToDouble(textBox3.Text);
            c.Depositar(Convert.ToDouble(textBox4.Text));
            textBox3.Text = c.SaldoConta.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.SaldoConta = Convert.ToDouble(textBox3.Text);
            c.Sacar(Convert.ToDouble(textBox4.Text));
            textBox3.Text = c.SaldoConta.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            textBox1.Text = c.titular.ToString();
            textBox2.Text = c.numeroConta.ToString();
            textBox3.Text = c.SaldoConta.ToString();
        }
    }
}

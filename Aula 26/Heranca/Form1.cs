using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "0";
        }
        class Conta
        {
            public string Titular { get; set; }
            public int Agencia { get; set; }
            public int Numero { get; set; }
            public int Tipo { get; set; }
            private double saldo = 0;
            public double Saldo
            {
                get { return this.saldo; }
                set { this.saldo = value; }
            }
            public virtual void Sacar(double valor)
            {
                this.saldo -= valor;
            }
            public void Depositar(double valor)
            {
                this.saldo += valor;
            }
        }
        class ContaPoupanca : Conta //Herança
        {
            public override void Sacar(double valor) //
            {
                this.Saldo -= valor + 0.10;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Conta Corrente")
            {
                Conta c = new Conta();
                c.Saldo = Convert.ToDouble(textBox4.Text);
                c.Depositar(Convert.ToDouble(textBox5.Text));
                textBox4.Text = Convert.ToString(c.Saldo);
            }
            if (comboBox1.Text == "Conta Poupanca")
            {
                ContaPoupanca p = new ContaPoupanca();
                p.Saldo = Convert.ToDouble(textBox4.Text);
                p.Depositar(Convert.ToDouble(textBox5.Text));
                textBox4.Text = Convert.ToString(p.Saldo);
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Você não selecionou o tipo de conta");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Conta Corrente")
            {
                Conta c = new Conta();
                c.Saldo = Convert.ToDouble(textBox4.Text);
                c.Sacar(Convert.ToDouble(textBox5.Text));
                textBox4.Text = Convert.ToString(c.Saldo);
            }
            if(comboBox1.Text == "Conta Poupanca")
            {
                ContaPoupanca p = new ContaPoupanca();
                p.Saldo = Convert.ToDouble(textBox4.Text);
                p.Sacar(Convert.ToDouble(textBox5.Text));
                textBox4.Text = Convert.ToString(p.Saldo);
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Você não selecionou o tipo de conta");
            }
        }
    }
}

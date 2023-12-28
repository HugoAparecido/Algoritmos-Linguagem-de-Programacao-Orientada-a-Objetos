using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAbstrata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "0";
        }

        abstract class Conta
        {
            public string cliente = "";
            public double saldo = 0;

            public double Saldo
            {
                get { return saldo; }
                set { this.saldo = value; }
            }
            public abstract double depositar();
            
        }

        class Poupanca : Conta
        {
           
            public double taxa = 10;
            public double valor;

            public Poupanca(double v)
            {
                valor = v;
            }

            public override double depositar ()
            {
                return this.Saldo += valor + (valor * ((this.taxa)/100)); 
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Poupanca p = new Poupanca(Convert.ToDouble(textBox3.Text));
            p.Saldo = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(p.depositar());
            textBox2.Text = Convert.ToString(p.Saldo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Cliente: " + textBox1.Text);
            listBox1.Items.Add("Saldo: " + textBox2.Text);

        }

        
    }
}

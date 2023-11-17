using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Empregado
        {
            public string nome { get; protected set; }
            public string sobrenome { get; protected set; }
            public string cpf { get; protected set; }
            public virtual double Vencimento()
            {
                return 0;
            }
        }
        class Assalariado : Empregado
        {
            private double salario = 0;
            public Assalariado(double salario)
            {
                this.salario = salario;
            }
            public override double Vencimento()
            {
                return this.salario;
            }
        }
        class Comissionado : Empregado
        {
            private double valorVenda;
            private double valorComissao;
            public Comissionado(double valorVenda, double valorComissao)
            {
                this.valorVenda = valorVenda;
                this.valorComissao = valorComissao;
            }
            public override double Vencimento()
            {
                return this.valorVenda + (this.valorVenda * (this.valorComissao/100));
            }
        }
        class Horista : Empregado
        {
            private double precoHora;
            private double horasTrabalhadas;
            public Horista(double precoHora, double horasTrabalhadas)
            {
                this.precoHora = precoHora;
                this.horasTrabalhadas = horasTrabalhadas;
            }
            public override double Vencimento()
            {
                return this.precoHora*this.horasTrabalhadas;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Assalariado")
            {
                textBox5.Visible = true;
                label6.Visible = true;
                textBox4.Visible = false;
                label4.Visible = false;
                comboBox2.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                label7.Visible = false;
            }
            if (comboBox1.Text == "Comissionado")
            {
                textBox4.Visible = true;
                label4.Visible = true;
                comboBox2.Visible = true;
                label8.Visible = true;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                label7.Visible = false;
            }
            if (comboBox1.Text == "Horista")
            {
                textBox6.Visible = true;
                label9.Visible = true;
                textBox7.Visible = true;
                label7.Visible = true;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox4.Visible = false;
                label4.Visible = false;
                comboBox2.Visible = false;
                label8.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Assalariado")
            {
                Assalariado a = new Assalariado(Convert.ToDouble(textBox5.Text));
                textBox8.Text = Convert.ToString(a.Vencimento());
            }

            if (comboBox1.Text == "Comissionado")
            {
                Comissionado comissionado = new Comissionado(Convert.ToDouble(textBox4.Text), Convert.ToDouble(comboBox2.SelectedItem));
                textBox8.Text = Convert.ToString(comissionado.Vencimento());
            }
            if (comboBox1.Text == "Horista")
            {
                Horista horista = new Horista(Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox6.Text));
                textBox8.Text = Convert.ToString(horista.Vencimento());
            }
        }
    }
}

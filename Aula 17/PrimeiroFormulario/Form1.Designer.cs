namespace PrimeiroFormulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultado = new TextBox();
            soma = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            multiplicacao = new Button();
            divisao = new Button();
            subtracao = new Button();
            conta = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // resultado
            // 
            resultado.Location = new Point(520, 80);
            resultado.Name = "resultado";
            resultado.Size = new Size(125, 27);
            resultado.TabIndex = 2;
            // 
            // soma
            // 
            soma.Location = new Point(216, 264);
            soma.Name = "soma";
            soma.Size = new Size(94, 29);
            soma.TabIndex = 3;
            soma.Text = "Soma";
            soma.UseVisualStyleBackColor = true;
            soma.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 109);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            label3.Click += Label3_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(416, 264);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(129, 29);
            multiplicacao.TabIndex = 7;
            multiplicacao.Text = "Multiplicação";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += Multiplicacao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(551, 264);
            divisao.Name = "divisao";
            divisao.Size = new Size(94, 29);
            divisao.TabIndex = 8;
            divisao.Text = "Divisão";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += Divisao_Click;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(316, 264);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(94, 29);
            subtracao.TabIndex = 9;
            subtracao.Text = "Subtração";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += Subtracao_Click;
            // 
            // conta
            // 
            conta.AutoSize = true;
            conta.Location = new Point(291, 83);
            conta.Name = "conta";
            conta.Size = new Size(0, 20);
            conta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 83);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 11;
            label4.Text = "=";
            label4.Click += Label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(conta);
            Controls.Add(subtracao);
            Controls.Add(divisao);
            Controls.Add(multiplicacao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(soma);
            Controls.Add(resultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Formulário Soma";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox resultado;
        private Button soma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button multiplicacao;
        private Button divisao;
        private Button subtracao;
        private Label conta;
        private Label label4;
    }
}
namespace Ativiade4Calculadora
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
            calculo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            clear = new Button();
            adicao = new Button();
            subtracao = new Button();
            multiplicacao = new Button();
            divisao = new Button();
            calcular = new Button();
            casaDecimal = new Button();
            ApagarUltimo = new Button();
            menuStrip1 = new MenuStrip();
            calculadoraCientíficaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            // 
            // calculo
            // 
            calculo.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            calculo.Location = new Point(11, 67);
            calculo.Name = "calculo";
            calculo.Size = new Size(274, 45);
            calculo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(11, 120);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(67, 120);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(123, 120);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(11, 176);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(67, 176);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(123, 176);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(11, 232);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(67, 232);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(123, 232);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(11, 288);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Button0_Click;
            // 
            // clear
            // 
            clear.Location = new Point(235, 120);
            clear.Name = "clear";
            clear.Size = new Size(50, 50);
            clear.TabIndex = 11;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = true;
            clear.Click += Clear_Click;
            // 
            // adicao
            // 
            adicao.Location = new Point(179, 120);
            adicao.Name = "adicao";
            adicao.Size = new Size(50, 50);
            adicao.TabIndex = 12;
            adicao.Text = "+";
            adicao.UseVisualStyleBackColor = true;
            adicao.Click += Adicao_Click;
            // 
            // subtracao
            // 
            subtracao.Location = new Point(179, 176);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(50, 50);
            subtracao.TabIndex = 13;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = true;
            subtracao.Click += Subtracao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.Location = new Point(179, 232);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(50, 50);
            multiplicacao.TabIndex = 14;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = true;
            multiplicacao.Click += Multiplicacao_Click;
            // 
            // divisao
            // 
            divisao.Location = new Point(179, 288);
            divisao.Name = "divisao";
            divisao.Size = new Size(50, 50);
            divisao.TabIndex = 15;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = true;
            divisao.Click += Divisao_Click;
            // 
            // calcular
            // 
            calcular.Location = new Point(235, 176);
            calcular.Name = "calcular";
            calcular.Size = new Size(50, 162);
            calcular.TabIndex = 16;
            calcular.Text = "=";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += Calcular_Click;
            // 
            // casaDecimal
            // 
            casaDecimal.Location = new Point(67, 288);
            casaDecimal.Name = "casaDecimal";
            casaDecimal.Size = new Size(50, 50);
            casaDecimal.TabIndex = 17;
            casaDecimal.Text = ",";
            casaDecimal.UseVisualStyleBackColor = true;
            casaDecimal.Click += CasaDecimal_Click;
            // 
            // ApagarUltimo
            // 
            ApagarUltimo.Location = new Point(123, 288);
            ApagarUltimo.Name = "ApagarUltimo";
            ApagarUltimo.Size = new Size(50, 50);
            ApagarUltimo.TabIndex = 18;
            ApagarUltimo.Text = "C";
            ApagarUltimo.UseVisualStyleBackColor = true;
            ApagarUltimo.Click += ApagarTudo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculadoraCientíficaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(297, 36);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraCientíficaToolStripMenuItem
            // 
            calculadoraCientíficaToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calculadoraCientíficaToolStripMenuItem.Name = "calculadoraCientíficaToolStripMenuItem";
            calculadoraCientíficaToolStripMenuItem.Size = new Size(214, 32);
            calculadoraCientíficaToolStripMenuItem.Text = "Calculadora Científica";
            calculadoraCientíficaToolStripMenuItem.Click += CalculadoraCientíficaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 347);
            Controls.Add(ApagarUltimo);
            Controls.Add(casaDecimal);
            Controls.Add(calcular);
            Controls.Add(divisao);
            Controls.Add(multiplicacao);
            Controls.Add(subtracao);
            Controls.Add(adicao);
            Controls.Add(clear);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(calculo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calculo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button clear;
        private Button adicao;
        private Button subtracao;
        private Button multiplicacao;
        private Button divisao;
        private Button calcular;
        private Button casaDecimal;
        private Button ApagarUltimo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculadoraCientíficaToolStripMenuItem;
    }
}
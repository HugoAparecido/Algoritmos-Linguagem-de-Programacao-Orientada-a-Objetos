namespace ProvaQuestao1
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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            empréstimoToolStripMenuItem = new ToolStripMenuItem();
            criarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            nomeCliente = new TextBox();
            valorEmprestimo = new TextBox();
            taxaJuros = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            totalJuros = new TextBox();
            totalPago = new TextBox();
            pagMensal = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, empréstimoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(154, 26);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += NovoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(154, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // empréstimoToolStripMenuItem
            // 
            empréstimoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarToolStripMenuItem, consultarToolStripMenuItem1, excluirToolStripMenuItem });
            empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            empréstimoToolStripMenuItem.Size = new Size(103, 24);
            empréstimoToolStripMenuItem.Text = "Empréstimo";
            // 
            // criarToolStripMenuItem
            // 
            criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            criarToolStripMenuItem.Size = new Size(224, 26);
            criarToolStripMenuItem.Text = "Criar";
            criarToolStripMenuItem.Click += criarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(224, 26);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(224, 26);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 109);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor do Empréstimo";
            // 
            // nomeCliente
            // 
            nomeCliente.Location = new Point(38, 72);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.Size = new Size(192, 27);
            nomeCliente.TabIndex = 3;
            // 
            // valorEmprestimo
            // 
            valorEmprestimo.Location = new Point(38, 132);
            valorEmprestimo.Name = "valorEmprestimo";
            valorEmprestimo.Size = new Size(192, 27);
            valorEmprestimo.TabIndex = 4;
            // 
            // taxaJuros
            // 
            taxaJuros.Location = new Point(38, 192);
            taxaJuros.Name = "taxaJuros";
            taxaJuros.Size = new Size(192, 27);
            taxaJuros.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 169);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Taxa de Juros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 236);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Prazo em Meses";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 mês", "2 meses", "3 meses", "4 meses", "5 meses", "6 meses", "7 meses", "8 meses", "9 meses", "10 meses" });
            comboBox1.Location = new Point(38, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(83, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(totalJuros);
            groupBox1.Controls.Add(totalPago);
            groupBox1.Controls.Add(pagMensal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(448, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 159);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Empréstimo";
            // 
            // totalJuros
            // 
            totalJuros.Location = new Point(166, 107);
            totalJuros.Name = "totalJuros";
            totalJuros.Size = new Size(125, 27);
            totalJuros.TabIndex = 5;
            // 
            // totalPago
            // 
            totalPago.Location = new Point(166, 67);
            totalPago.Name = "totalPago";
            totalPago.Size = new Size(125, 27);
            totalPago.TabIndex = 4;
            // 
            // pagMensal
            // 
            pagMensal.Location = new Point(166, 34);
            pagMensal.Name = "pagMensal";
            pagMensal.Size = new Size(129, 27);
            pagMensal.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 114);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 2;
            label7.Text = "Total Juros Pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 1;
            label6.Text = "Valor Total Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 37);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 0;
            label5.Text = "Pagamento Mensal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(taxaJuros);
            Controls.Add(valorEmprestimo);
            Controls.Add(nomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem empréstimoToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox nomeCliente;
        private TextBox valorEmprestimo;
        private TextBox taxaJuros;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox totalJuros;
        private TextBox totalPago;
        private TextBox pagMensal;
        private Label label7;
        private Label label6;
        private Label label5;
        private ToolStripMenuItem criarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem excluirToolStripMenuItem;
    }
}
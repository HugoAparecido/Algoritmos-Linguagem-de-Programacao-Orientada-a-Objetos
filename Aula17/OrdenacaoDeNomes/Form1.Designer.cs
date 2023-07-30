namespace OrdenacaoDeNomes
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
            label1 = new Label();
            nome1 = new TextBox();
            nome2 = new TextBox();
            nome3 = new TextBox();
            exibirNomes = new ListBox();
            organizarNomes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite os nomes em cada caixa a seguir:";
            // 
            // nome1
            // 
            nome1.Location = new Point(256, 63);
            nome1.Name = "nome1";
            nome1.Size = new Size(275, 27);
            nome1.TabIndex = 1;
            // 
            // nome2
            // 
            nome2.Location = new Point(256, 128);
            nome2.Name = "nome2";
            nome2.Size = new Size(275, 27);
            nome2.TabIndex = 2;
            // 
            // nome3
            // 
            nome3.Location = new Point(256, 200);
            nome3.Name = "nome3";
            nome3.Size = new Size(275, 27);
            nome3.TabIndex = 3;
            // 
            // exibirNomes
            // 
            exibirNomes.FormattingEnabled = true;
            exibirNomes.ItemHeight = 20;
            exibirNomes.Location = new Point(256, 302);
            exibirNomes.Name = "exibirNomes";
            exibirNomes.Size = new Size(275, 104);
            exibirNomes.TabIndex = 4;
            // 
            // organizarNomes
            // 
            organizarNomes.Location = new Point(256, 257);
            organizarNomes.Name = "organizarNomes";
            organizarNomes.Size = new Size(275, 29);
            organizarNomes.TabIndex = 5;
            organizarNomes.Text = "Organizar em ordem alfabética";
            organizarNomes.UseVisualStyleBackColor = true;
            organizarNomes.Click += OrganizarNomes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(organizarNomes);
            Controls.Add(exibirNomes);
            Controls.Add(nome3);
            Controls.Add(nome2);
            Controls.Add(nome1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nome1;
        private TextBox nome2;
        private TextBox nome3;
        private ListBox exibirNomes;
        private Button organizarNomes;
    }
}
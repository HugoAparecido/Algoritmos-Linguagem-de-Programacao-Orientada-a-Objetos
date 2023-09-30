namespace ProvaQuestao1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mostrar = new Button();
            listaClientes = new ListBox();
            label1 = new Label();
            dadosEmprestimo = new ListBox();
            SuspendLayout();
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(77, 12);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(115, 29);
            Mostrar.TabIndex = 5;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // listaClientes
            // 
            listaClientes.FormattingEnabled = true;
            listaClientes.ItemHeight = 20;
            listaClientes.Location = new Point(139, 78);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(173, 24);
            listaClientes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome cliente";
            // 
            // dadosEmprestimo
            // 
            dadosEmprestimo.FormattingEnabled = true;
            dadosEmprestimo.ItemHeight = 20;
            dadosEmprestimo.Location = new Point(12, 125);
            dadosEmprestimo.Name = "dadosEmprestimo";
            dadosEmprestimo.Size = new Size(776, 64);
            dadosEmprestimo.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dadosEmprestimo);
            Controls.Add(Mostrar);
            Controls.Add(listaClientes);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Mostrar;
        private ListBox listaClientes;
        private Label label1;
        private ListBox dadosEmprestimo;
    }
}
namespace ProvaQuestao1
{
    partial class Form2
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
            label1 = new Label();
            listaClientes = new ListBox();
            Mostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 64);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista Clientes";
            // 
            // listaClientes
            // 
            listaClientes.FormattingEnabled = true;
            listaClientes.ItemHeight = 20;
            listaClientes.Location = new Point(205, 152);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(274, 104);
            listaClientes.TabIndex = 1;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(205, 100);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(94, 29);
            Mostrar.TabIndex = 2;
            Mostrar.Text = "Mostrar";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mostrar);
            Controls.Add(listaClientes);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listaClientes;
        private Button Mostrar;
    }
}
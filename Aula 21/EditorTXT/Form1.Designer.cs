namespace EditorTXT
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
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            opçõesDeAçãoToolStripMenuItem = new ToolStripMenuItem();
            salvarTextoToolStripMenuItem = new ToolStripMenuItem();
            abrirTextoToolStripMenuItem = new ToolStripMenuItem();
            abrirLocalmenteToolStripMenuItem = new ToolStripMenuItem();
            abrirComONotepadToolStripMenuItem = new ToolStripMenuItem();
            deletarTextoToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(899, 494);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesDeAçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(899, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesDeAçãoToolStripMenuItem
            // 
            opçõesDeAçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvarTextoToolStripMenuItem, abrirTextoToolStripMenuItem, deletarTextoToolStripMenuItem });
            opçõesDeAçãoToolStripMenuItem.Name = "opçõesDeAçãoToolStripMenuItem";
            opçõesDeAçãoToolStripMenuItem.Size = new Size(132, 24);
            opçõesDeAçãoToolStripMenuItem.Text = "Opções de Ação";
            // 
            // salvarTextoToolStripMenuItem
            // 
            salvarTextoToolStripMenuItem.Name = "salvarTextoToolStripMenuItem";
            salvarTextoToolStripMenuItem.Size = new Size(224, 26);
            salvarTextoToolStripMenuItem.Text = "Salvar Texto";
            salvarTextoToolStripMenuItem.Click += SalvarTextoToolStripMenuItem_Click;
            // 
            // abrirTextoToolStripMenuItem
            // 
            abrirTextoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirLocalmenteToolStripMenuItem, abrirComONotepadToolStripMenuItem });
            abrirTextoToolStripMenuItem.Name = "abrirTextoToolStripMenuItem";
            abrirTextoToolStripMenuItem.Size = new Size(224, 26);
            abrirTextoToolStripMenuItem.Text = "Abrir Texto";
            // 
            // abrirLocalmenteToolStripMenuItem
            // 
            abrirLocalmenteToolStripMenuItem.Name = "abrirLocalmenteToolStripMenuItem";
            abrirLocalmenteToolStripMenuItem.Size = new Size(231, 26);
            abrirLocalmenteToolStripMenuItem.Text = "Abrir Localmente";
            abrirLocalmenteToolStripMenuItem.Click += AbrirLocalmenteToolStripMenuItem_Click;
            // 
            // abrirComONotepadToolStripMenuItem
            // 
            abrirComONotepadToolStripMenuItem.Name = "abrirComONotepadToolStripMenuItem";
            abrirComONotepadToolStripMenuItem.Size = new Size(231, 26);
            abrirComONotepadToolStripMenuItem.Text = "Abrir com o notepad";
            abrirComONotepadToolStripMenuItem.Click += abrirComONotepadToolStripMenuItem_Click;
            // 
            // deletarTextoToolStripMenuItem
            // 
            deletarTextoToolStripMenuItem.Name = "deletarTextoToolStripMenuItem";
            deletarTextoToolStripMenuItem.Size = new Size(224, 26);
            deletarTextoToolStripMenuItem.Text = "Deletar Texto";
            deletarTextoToolStripMenuItem.Click += deletarTextoToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(875, 484);
            listBox1.TabIndex = 2;
            listBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 522);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesDeAçãoToolStripMenuItem;
        private ToolStripMenuItem salvarTextoToolStripMenuItem;
        private ToolStripMenuItem abrirTextoToolStripMenuItem;
        private ToolStripMenuItem deletarTextoToolStripMenuItem;
        private ToolStripMenuItem abrirLocalmenteToolStripMenuItem;
        private ToolStripMenuItem abrirComONotepadToolStripMenuItem;
        private ListBox listBox1;
    }
}
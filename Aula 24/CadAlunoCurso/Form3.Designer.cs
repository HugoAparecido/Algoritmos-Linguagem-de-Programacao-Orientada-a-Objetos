namespace CadAlunoCurso
{
    partial class FormCadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarCurso = new System.Windows.Forms.Button();
            this.atualizarCurso = new System.Windows.Forms.Button();
            this.cadastrarCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caixaInserirCargaHoraria = new System.Windows.Forms.TextBox();
            this.caixaMostrarCodigo = new System.Windows.Forms.TextBox();
            this.caixaInserirNomeCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.escolherPeriodo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.AlunoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.CursoToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.PesquisarToolStripMenuItem_Click);
            // 
            // deletarCurso
            // 
            this.deletarCurso.Location = new System.Drawing.Point(310, 297);
            this.deletarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.deletarCurso.Name = "deletarCurso";
            this.deletarCurso.Size = new System.Drawing.Size(100, 56);
            this.deletarCurso.TabIndex = 67;
            this.deletarCurso.Text = "Deletar";
            this.deletarCurso.UseVisualStyleBackColor = true;
            this.deletarCurso.Click += new System.EventHandler(this.DeletarCurso_Click);
            // 
            // atualizarCurso
            // 
            this.atualizarCurso.Location = new System.Drawing.Point(185, 297);
            this.atualizarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.atualizarCurso.Name = "atualizarCurso";
            this.atualizarCurso.Size = new System.Drawing.Size(100, 56);
            this.atualizarCurso.TabIndex = 66;
            this.atualizarCurso.Text = "Atualizar";
            this.atualizarCurso.UseVisualStyleBackColor = true;
            this.atualizarCurso.Click += new System.EventHandler(this.AtualizarCurso_Click);
            // 
            // cadastrarCurso
            // 
            this.cadastrarCurso.Location = new System.Drawing.Point(58, 297);
            this.cadastrarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cadastrarCurso.Name = "cadastrarCurso";
            this.cadastrarCurso.Size = new System.Drawing.Size(100, 56);
            this.cadastrarCurso.TabIndex = 65;
            this.cadastrarCurso.Text = "Cadastrar";
            this.cadastrarCurso.UseVisualStyleBackColor = true;
            this.cadastrarCurso.Click += new System.EventHandler(this.CadastrarCurso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Carga Horaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nome";
            // 
            // caixaInserirCargaHoraria
            // 
            this.caixaInserirCargaHoraria.Location = new System.Drawing.Point(120, 209);
            this.caixaInserirCargaHoraria.Margin = new System.Windows.Forms.Padding(4);
            this.caixaInserirCargaHoraria.Multiline = true;
            this.caixaInserirCargaHoraria.Name = "caixaInserirCargaHoraria";
            this.caixaInserirCargaHoraria.Size = new System.Drawing.Size(307, 24);
            this.caixaInserirCargaHoraria.TabIndex = 59;
            // 
            // caixaMostrarCodigo
            // 
            this.caixaMostrarCodigo.Enabled = false;
            this.caixaMostrarCodigo.Location = new System.Drawing.Point(120, 161);
            this.caixaMostrarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.caixaMostrarCodigo.Multiline = true;
            this.caixaMostrarCodigo.Name = "caixaMostrarCodigo";
            this.caixaMostrarCodigo.ReadOnly = true;
            this.caixaMostrarCodigo.Size = new System.Drawing.Size(307, 24);
            this.caixaMostrarCodigo.TabIndex = 58;
            // 
            // caixaInserirNomeCurso
            // 
            this.caixaInserirNomeCurso.Location = new System.Drawing.Point(120, 115);
            this.caixaInserirNomeCurso.Margin = new System.Windows.Forms.Padding(4);
            this.caixaInserirNomeCurso.Multiline = true;
            this.caixaInserirNomeCurso.Name = "caixaInserirNomeCurso";
            this.caixaInserirNomeCurso.Size = new System.Drawing.Size(307, 24);
            this.caixaInserirNomeCurso.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cadastrar Curso";
            // 
            // escolherPeriodo
            // 
            this.escolherPeriodo.FormattingEnabled = true;
            this.escolherPeriodo.Items.AddRange(new object[] {
            "Diurno",
            "Integral",
            "Noturno"});
            this.escolherPeriodo.Location = new System.Drawing.Point(120, 254);
            this.escolherPeriodo.Name = "escolherPeriodo";
            this.escolherPeriodo.Size = new System.Drawing.Size(307, 24);
            this.escolherPeriodo.TabIndex = 68;
            // 
            // FormCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 381);
            this.Controls.Add(this.escolherPeriodo);
            this.Controls.Add(this.deletarCurso);
            this.Controls.Add(this.atualizarCurso);
            this.Controls.Add(this.cadastrarCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caixaInserirCargaHoraria);
            this.Controls.Add(this.caixaMostrarCodigo);
            this.Controls.Add(this.caixaInserirNomeCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroCurso";
            this.Text = "Cadastro Curso";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.Button deletarCurso;
        private System.Windows.Forms.Button atualizarCurso;
        private System.Windows.Forms.Button cadastrarCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caixaInserirCargaHoraria;
        private System.Windows.Forms.TextBox caixaMostrarCodigo;
        private System.Windows.Forms.TextBox caixaInserirNomeCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox escolherPeriodo;
    }
}
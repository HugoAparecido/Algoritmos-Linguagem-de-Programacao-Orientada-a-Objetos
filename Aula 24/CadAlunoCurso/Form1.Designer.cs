namespace CadAlunoCurso
{
    partial class FormPesquisa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.caixaPesquisaAluno = new System.Windows.Forms.TextBox();
            this.buscarAluno = new System.Windows.Forms.Button();
            this.visualizacaoCurso = new System.Windows.Forms.ListView();
            this.visualizacaoAluno = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caixaPesquisaCurso = new System.Windows.Forms.TextBox();
            this.pesquisarCurso = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // caixaPesquisaAluno
            // 
            this.caixaPesquisaAluno.Location = new System.Drawing.Point(450, 318);
            this.caixaPesquisaAluno.Name = "caixaPesquisaAluno";
            this.caixaPesquisaAluno.Size = new System.Drawing.Size(543, 22);
            this.caixaPesquisaAluno.TabIndex = 18;
            // 
            // buscarAluno
            // 
            this.buscarAluno.Location = new System.Drawing.Point(300, 306);
            this.buscarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.buscarAluno.Name = "buscarAluno";
            this.buscarAluno.Size = new System.Drawing.Size(143, 47);
            this.buscarAluno.TabIndex = 17;
            this.buscarAluno.Text = "Buscar";
            this.buscarAluno.UseVisualStyleBackColor = true;
            this.buscarAluno.Click += new System.EventHandler(this.BuscarAluno_Click);
            // 
            // visualizacaoCurso
            // 
            this.visualizacaoCurso.BackColor = System.Drawing.SystemColors.Window;
            this.visualizacaoCurso.HideSelection = false;
            this.visualizacaoCurso.Location = new System.Drawing.Point(300, 426);
            this.visualizacaoCurso.Margin = new System.Windows.Forms.Padding(4);
            this.visualizacaoCurso.MultiSelect = false;
            this.visualizacaoCurso.Name = "visualizacaoCurso";
            this.visualizacaoCurso.Size = new System.Drawing.Size(693, 222);
            this.visualizacaoCurso.TabIndex = 16;
            this.visualizacaoCurso.UseCompatibleStateImageBehavior = false;
            this.visualizacaoCurso.SelectedIndexChanged += new System.EventHandler(this.VisualizacaoCurso_SelectedIndexChanged);
            // 
            // visualizacaoAluno
            // 
            this.visualizacaoAluno.HideSelection = false;
            this.visualizacaoAluno.Location = new System.Drawing.Point(13, 91);
            this.visualizacaoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.visualizacaoAluno.MultiSelect = false;
            this.visualizacaoAluno.Name = "visualizacaoAluno";
            this.visualizacaoAluno.Size = new System.Drawing.Size(1279, 206);
            this.visualizacaoAluno.TabIndex = 15;
            this.visualizacaoAluno.UseCompatibleStateImageBehavior = false;
            this.visualizacaoAluno.SelectedIndexChanged += new System.EventHandler(this.VisualizacaoAluno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 53);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consultar Curso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultar Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caixaPesquisaCurso
            // 
            this.caixaPesquisaCurso.Location = new System.Drawing.Point(450, 677);
            this.caixaPesquisaCurso.Name = "caixaPesquisaCurso";
            this.caixaPesquisaCurso.Size = new System.Drawing.Size(543, 22);
            this.caixaPesquisaCurso.TabIndex = 20;
            // 
            // pesquisarCurso
            // 
            this.pesquisarCurso.Location = new System.Drawing.Point(300, 665);
            this.pesquisarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisarCurso.Name = "pesquisarCurso";
            this.pesquisarCurso.Size = new System.Drawing.Size(143, 47);
            this.pesquisarCurso.TabIndex = 19;
            this.pesquisarCurso.Text = "Buscar";
            this.pesquisarCurso.UseVisualStyleBackColor = true;
            this.pesquisarCurso.Click += new System.EventHandler(this.PesquisarCurso_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1305, 28);
            this.menuStrip1.TabIndex = 21;
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
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 819);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.caixaPesquisaCurso);
            this.Controls.Add(this.pesquisarCurso);
            this.Controls.Add(this.caixaPesquisaAluno);
            this.Controls.Add(this.buscarAluno);
            this.Controls.Add(this.visualizacaoCurso);
            this.Controls.Add(this.visualizacaoAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisa";
            this.Text = "Área de Pesquisa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixaPesquisaAluno;
        private System.Windows.Forms.Button buscarAluno;
        private System.Windows.Forms.ListView visualizacaoCurso;
        private System.Windows.Forms.ListView visualizacaoAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixaPesquisaCurso;
        private System.Windows.Forms.Button pesquisarCurso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
    }
}


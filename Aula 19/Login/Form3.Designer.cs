namespace Login
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            nome = new Label();
            email = new Label();
            sobrenome = new Label();
            label1 = new Label();
            senha = new Label();
            confirmarSenha = new Label();
            nomeText = new TextBox();
            emailText = new TextBox();
            sobrenomeText = new TextBox();
            usuarioText = new TextBox();
            confirmarSenhaText = new TextBox();
            button1 = new Button();
            senhaText = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(20, 74);
            nome.Name = "nome";
            nome.Size = new Size(50, 20);
            nome.TabIndex = 0;
            nome.Text = "Nome";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(17, 125);
            email.Name = "email";
            email.Size = new Size(52, 20);
            email.TabIndex = 1;
            email.Text = "E-mail";
            // 
            // sobrenome
            // 
            sobrenome.AutoSize = true;
            sobrenome.Location = new Point(217, 74);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(86, 20);
            sobrenome.TabIndex = 2;
            sobrenome.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 128);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Location = new Point(21, 180);
            senha.Name = "senha";
            senha.Size = new Size(49, 20);
            senha.TabIndex = 4;
            senha.Text = "Senha";
            // 
            // confirmarSenha
            // 
            confirmarSenha.AutoSize = true;
            confirmarSenha.Location = new Point(382, 180);
            confirmarSenha.Name = "confirmarSenha";
            confirmarSenha.Size = new Size(124, 20);
            confirmarSenha.TabIndex = 5;
            confirmarSenha.Text = "Confirme a senha";
            // 
            // nomeText
            // 
            nomeText.Location = new Point(75, 71);
            nomeText.Name = "nomeText";
            nomeText.Size = new Size(125, 27);
            nomeText.TabIndex = 6;
            // 
            // emailText
            // 
            emailText.Location = new Point(75, 122);
            emailText.Name = "emailText";
            emailText.Size = new Size(392, 27);
            emailText.TabIndex = 7;
            // 
            // sobrenomeText
            // 
            sobrenomeText.Location = new Point(308, 71);
            sobrenomeText.Name = "sobrenomeText";
            sobrenomeText.Size = new Size(371, 27);
            sobrenomeText.TabIndex = 8;
            // 
            // usuarioText
            // 
            usuarioText.Location = new Point(554, 125);
            usuarioText.Name = "usuarioText";
            usuarioText.Size = new Size(125, 27);
            usuarioText.TabIndex = 9;
            // 
            // confirmarSenhaText
            // 
            confirmarSenhaText.Location = new Point(512, 180);
            confirmarSenhaText.Name = "confirmarSenhaText";
            confirmarSenhaText.Size = new Size(125, 27);
            confirmarSenhaText.TabIndex = 10;
            confirmarSenhaText.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(294, 247);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // senhaText
            // 
            senhaText.Location = new Point(75, 177);
            senhaText.Name = "senhaText";
            senhaText.Size = new Size(125, 27);
            senhaText.TabIndex = 12;
            senhaText.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 46);
            label2.TabIndex = 13;
            label2.Text = "Cadastro:";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(643, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += PictureBox2_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 311);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(senhaText);
            Controls.Add(button1);
            Controls.Add(confirmarSenhaText);
            Controls.Add(usuarioText);
            Controls.Add(sobrenomeText);
            Controls.Add(emailText);
            Controls.Add(nomeText);
            Controls.Add(confirmarSenha);
            Controls.Add(senha);
            Controls.Add(label1);
            Controls.Add(sobrenome);
            Controls.Add(email);
            Controls.Add(nome);
            Name = "TelaCadastro";
            Text = "Tela de Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nome;
        private Label email;
        private Label sobrenome;
        private Label label1;
        private Label senha;
        private Label confirmarSenha;
        private TextBox nomeText;
        private TextBox emailText;
        private TextBox sobrenomeText;
        private TextBox usuarioText;
        private TextBox confirmarSenhaText;
        private Button button1;
        private TextBox senhaText;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
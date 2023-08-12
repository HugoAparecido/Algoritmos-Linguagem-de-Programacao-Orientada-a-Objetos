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
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(291, 55);
            nome.Name = "nome";
            nome.Size = new Size(50, 20);
            nome.TabIndex = 0;
            nome.Text = "Nome";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(289, 162);
            email.Name = "email";
            email.Size = new Size(52, 20);
            email.TabIndex = 1;
            email.Text = "E-mail";
            // 
            // sobrenome
            // 
            sobrenome.AutoSize = true;
            sobrenome.Location = new Point(255, 110);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(86, 20);
            sobrenome.TabIndex = 2;
            sobrenome.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 207);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Location = new Point(292, 254);
            senha.Name = "senha";
            senha.Size = new Size(49, 20);
            senha.TabIndex = 4;
            senha.Text = "Senha";
            // 
            // confirmarSenha
            // 
            confirmarSenha.AutoSize = true;
            confirmarSenha.Location = new Point(217, 298);
            confirmarSenha.Name = "confirmarSenha";
            confirmarSenha.Size = new Size(124, 20);
            confirmarSenha.TabIndex = 5;
            confirmarSenha.Text = "Confirme a senha";
            // 
            // nomeText
            // 
            nomeText.Location = new Point(347, 55);
            nomeText.Name = "nomeText";
            nomeText.Size = new Size(125, 27);
            nomeText.TabIndex = 6;
            // 
            // emailText
            // 
            emailText.Location = new Point(347, 162);
            emailText.Name = "emailText";
            emailText.Size = new Size(125, 27);
            emailText.TabIndex = 7;
            // 
            // sobrenomeText
            // 
            sobrenomeText.Location = new Point(347, 110);
            sobrenomeText.Name = "sobrenomeText";
            sobrenomeText.Size = new Size(125, 27);
            sobrenomeText.TabIndex = 8;
            // 
            // usuarioText
            // 
            usuarioText.Location = new Point(347, 204);
            usuarioText.Name = "usuarioText";
            usuarioText.Size = new Size(125, 27);
            usuarioText.TabIndex = 9;
            // 
            // confirmarSenhaText
            // 
            confirmarSenhaText.Location = new Point(347, 298);
            confirmarSenhaText.Name = "confirmarSenhaText";
            confirmarSenhaText.Size = new Size(125, 27);
            confirmarSenhaText.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(325, 381);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // senhaText
            // 
            senhaText.Location = new Point(347, 251);
            senhaText.Name = "senhaText";
            senhaText.Size = new Size(125, 27);
            senhaText.TabIndex = 12;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
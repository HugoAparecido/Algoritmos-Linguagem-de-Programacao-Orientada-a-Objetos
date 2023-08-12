namespace Login
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 127);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 185);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 127);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Usuário";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 185);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Senha";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(358, 248);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(297, 57);
            label3.Name = "label3";
            label3.Size = new Size(217, 46);
            label3.TabIndex = 5;
            label3.Text = "Tela de Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(358, 294);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 7;
            button2.Text = "Cadastrar-se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaLogin";
            Text = "Login do Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
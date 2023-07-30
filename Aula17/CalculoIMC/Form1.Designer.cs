namespace CalculoIMC
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
            calcularIMC = new Button();
            altura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            peso = new TextBox();
            imc = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // calcularIMC
            // 
            calcularIMC.Location = new Point(363, 362);
            calcularIMC.Name = "calcularIMC";
            calcularIMC.Size = new Size(128, 29);
            calcularIMC.TabIndex = 0;
            calcularIMC.Text = "Calcular IMC";
            calcularIMC.UseVisualStyleBackColor = true;
            calcularIMC.Click += CalcularIMC_Click;
            // 
            // altura
            // 
            altura.Location = new Point(366, 117);
            altura.Name = "altura";
            altura.PlaceholderText = "Ex: 1,8";
            altura.Size = new Size(125, 27);
            altura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 97);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Altura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 178);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Peso (Kg):";
            // 
            // peso
            // 
            peso.Location = new Point(366, 210);
            peso.Name = "peso";
            peso.PlaceholderText = "Ex: 50,8";
            peso.Size = new Size(125, 27);
            peso.TabIndex = 4;
            // 
            // imc
            // 
            imc.Location = new Point(366, 305);
            imc.Name = "imc";
            imc.Size = new Size(125, 27);
            imc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 282);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "IMC: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(imc);
            Controls.Add(peso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(altura);
            Controls.Add(calcularIMC);
            Name = "Form1";
            Text = "Cálculo IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcularIMC;
        private TextBox altura;
        private Label label1;
        private Label label2;
        private TextBox peso;
        private TextBox imc;
        private Label label3;
    }
}
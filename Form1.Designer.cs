namespace CalculadoraSimples
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
            txtResultado = new TextBox();
            lblOperacao = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnSubtrair = new Button();
            btnIgual = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btnSomar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(23, 27);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(258, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(27, 29);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(23, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 45);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(84, 230);
            btn2.Name = "btn2";
            btn2.Size = new Size(55, 45);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(145, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(55, 45);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(145, 179);
            btn6.Name = "btn6";
            btn6.Size = new Size(55, 45);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(84, 179);
            btn5.Name = "btn5";
            btn5.Size = new Size(55, 45);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(23, 179);
            btn4.Name = "btn4";
            btn4.Size = new Size(55, 45);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(145, 128);
            btn9.Name = "btn9";
            btn9.Size = new Size(55, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(84, 128);
            btn8.Name = "btn8";
            btn8.Size = new Size(55, 45);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(23, 128);
            btn7.Name = "btn7";
            btn7.Size = new Size(55, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(226, 128);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(55, 45);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(226, 179);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(55, 45);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtrair.Location = new Point(226, 230);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(55, 45);
            btnSubtrair.TabIndex = 11;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(145, 281);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(55, 45);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(84, 281);
            btn0.Name = "btn0";
            btn0.Size = new Size(55, 45);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(23, 281);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(55, 45);
            btnVirgula.TabIndex = 14;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnSomar
            // 
            btnSomar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSomar.Location = new Point(226, 281);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(55, 45);
            btnSomar.TabIndex = 17;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(226, 77);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(55, 45);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 348);
            Controls.Add(btnLimpar);
            Controls.Add(btnSomar);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnVirgula);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label lblOperacao;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnSubtrair;
        private Button btnIgual;
        private Button btn0;
        private Button btnVirgula;
        private Button btnSomar;
        private Button btnLimpar;
    }
}

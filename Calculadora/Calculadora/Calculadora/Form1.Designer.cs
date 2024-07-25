namespace Calculadora
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
            display = new TextBox();
            displayText = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            divisao = new Button();
            multiplicacao = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            subtracao = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            soma = new Button();
            btnResultado = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btnLimparDisplay = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.Cursor = Cursors.IBeam;
            display.Font = new Font("Segoe UI", 20F);
            display.Location = new Point(32, 39);
            display.Margin = new Padding(10);
            display.Name = "display";
            display.PlaceholderText = "0";
            display.ReadOnly = true;
            display.Size = new Size(323, 43);
            display.TabIndex = 0;
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // displayText
            // 
            displayText.AutoSize = true;
            displayText.BackColor = SystemColors.Control;
            displayText.Font = new Font("Segoe UI", 15F);
            displayText.Location = new Point(45, 45);
            displayText.Name = "displayText";
            displayText.Size = new Size(0, 28);
            displayText.TabIndex = 1;
            displayText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(187, 222, 240);
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.ForeColor = Color.FromArgb(54, 59, 61);
            btn7.Location = new Point(32, 153);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 60);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(187, 222, 240);
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.ForeColor = Color.FromArgb(54, 59, 61);
            btn8.Location = new Point(115, 153);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 60);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(187, 222, 240);
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.ForeColor = Color.FromArgb(54, 59, 61);
            btn9.Location = new Point(198, 153);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 60);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // divisao
            // 
            divisao.BackColor = Color.FromArgb(244, 159, 10);
            divisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            divisao.ForeColor = Color.White;
            divisao.Location = new Point(280, 153);
            divisao.Name = "divisao";
            divisao.Size = new Size(75, 60);
            divisao.TabIndex = 5;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = false;
            divisao.Click += divisao_Click;
            // 
            // multiplicacao
            // 
            multiplicacao.BackColor = Color.FromArgb(244, 159, 10);
            multiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            multiplicacao.ForeColor = Color.White;
            multiplicacao.Location = new Point(280, 229);
            multiplicacao.Name = "multiplicacao";
            multiplicacao.Size = new Size(75, 60);
            multiplicacao.TabIndex = 9;
            multiplicacao.Text = "*";
            multiplicacao.UseVisualStyleBackColor = false;
            multiplicacao.Click += multiplicacao_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(187, 222, 240);
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.ForeColor = Color.FromArgb(54, 59, 61);
            btn6.Location = new Point(198, 229);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 60);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(187, 222, 240);
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.ForeColor = Color.FromArgb(54, 59, 61);
            btn5.Location = new Point(115, 229);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(187, 222, 240);
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.ForeColor = Color.FromArgb(54, 59, 61);
            btn4.Location = new Point(32, 229);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 60);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // subtracao
            // 
            subtracao.BackColor = Color.FromArgb(244, 159, 10);
            subtracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            subtracao.ForeColor = Color.White;
            subtracao.Location = new Point(280, 304);
            subtracao.Name = "subtracao";
            subtracao.Size = new Size(75, 60);
            subtracao.TabIndex = 13;
            subtracao.Text = "-";
            subtracao.UseVisualStyleBackColor = false;
            subtracao.Click += subtracao_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(187, 222, 240);
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.ForeColor = Color.FromArgb(54, 59, 61);
            btn3.Location = new Point(198, 304);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 60);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(187, 222, 240);
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(54, 59, 61);
            btn2.Location = new Point(115, 304);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 60);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(187, 222, 240);
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.ForeColor = Color.FromArgb(54, 59, 61);
            btn1.Location = new Point(32, 304);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 60);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // soma
            // 
            soma.BackColor = Color.FromArgb(244, 159, 10);
            soma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            soma.ForeColor = Color.White;
            soma.Location = new Point(280, 380);
            soma.Name = "soma";
            soma.Size = new Size(75, 60);
            soma.TabIndex = 17;
            soma.Text = "+";
            soma.UseVisualStyleBackColor = false;
            soma.Click += soma_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.FromArgb(240, 135, 0);
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResultado.ForeColor = Color.White;
            btnResultado.Location = new Point(198, 380);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(75, 60);
            btnResultado.TabIndex = 16;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(187, 222, 240);
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.ForeColor = Color.FromArgb(54, 59, 61);
            btn0.Location = new Point(115, 380);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 60);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(240, 135, 0);
            btnVirgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(32, 380);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 60);
            btnVirgula.TabIndex = 14;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnLimparDisplay
            // 
            btnLimparDisplay.BackColor = Color.FromArgb(244, 159, 10);
            btnLimparDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimparDisplay.ForeColor = Color.White;
            btnLimparDisplay.Location = new Point(280, 104);
            btnLimparDisplay.Name = "btnLimparDisplay";
            btnLimparDisplay.Size = new Size(75, 40);
            btnLimparDisplay.TabIndex = 18;
            btnLimparDisplay.Text = "C";
            btnLimparDisplay.UseVisualStyleBackColor = false;
            btnLimparDisplay.Click += btnLimparDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 166, 166);
            ClientSize = new Size(384, 461);
            Controls.Add(btnLimparDisplay);
            Controls.Add(soma);
            Controls.Add(btnResultado);
            Controls.Add(btn0);
            Controls.Add(btnVirgula);
            Controls.Add(subtracao);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(multiplicacao);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(divisao);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(displayText);
            Controls.Add(display);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Label displayText;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button divisao;
        private Button multiplicacao;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button subtracao;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button soma;
        private Button btnResultado;
        private Button btn0;
        private Button btnVirgula;
        private Button btnLimparDisplay;
    }
}

using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Form1 : Form

    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
        private Operacoes operacaoSelecionada { get; set; }
        private enum Operacoes
        {
            Soma,
            Subtracao,
            Divisao,
            Multiplicacao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void soma_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacoes.Soma;
            valor = Convert.ToDecimal(display.Text);

            display.Text = "";
            displayText.Text = "+";
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacoes.Subtracao;
            valor = Convert.ToDecimal(display.Text);
            display.Text = "";
            displayText.Text = "-";

        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacoes.Multiplicacao;
            valor = Convert.ToDecimal(display.Text);
            display.Text = "";
            displayText.Text = "*";

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacoes.Divisao;
            valor = Convert.ToDecimal(display.Text);
            display.Text = "";
            displayText.Text = "/";

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                case Operacoes.Soma:
                    resultado = valor + Convert.ToDecimal(display.Text);
                    break;
                case Operacoes.Subtracao:
                    resultado = valor - Convert.ToDecimal(display.Text);
                    break;
                case Operacoes.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(display.Text);
                    break;
                case Operacoes.Divisao:
                    resultado = valor / Convert.ToDecimal(display.Text);
                    break;
                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
            display.Text = resultado.ToString();
            displayText.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(",")){
                display.Text += ",";
            }
        }

        private void btnLimparDisplay_Click(object sender, EventArgs e)
        {
            display.Text = "";
            displayText.Text = "";

        }
    }
}

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set;}
        public decimal Valor { get; set; }

        private operacao OperacaoSelecionada { get; set; }

        private enum operacao
        { 
        Adicao,
        Subtracao,
        Multiplicacao,
        Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)

            {

                case operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text); break;

                case operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text); break;

                case operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text); break;

                case operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text); break;

            } txtResultado.Text = Convert.ToString(Resultado);
        }
    }
}

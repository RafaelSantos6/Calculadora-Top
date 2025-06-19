namespace Calculadora_Top
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
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

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebarPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
                btnMenu.Text = "Menu";
            }
            else
            {
                sidebarPanel.Visible = true;
                btnMenu.Text = "Fechar Menu";
            }
        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperacao.Text = "+";


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperacao.Text = "-";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperacao.Text = "X";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            lblOperacao.Text = "/";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperacao.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResult.Text);
                    break;
            }
            txtResult.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

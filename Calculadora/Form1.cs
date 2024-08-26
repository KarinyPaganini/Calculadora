namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao Operacao_Selecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_um_Click(object sender, EventArgs e)
        {

            lbl_Visor.Text += "1";

        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "3";
        }
        private void btn_quatro_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "0";
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            Operacao_Selecionada = Operacao.Adicao;
            Valor = decimal.Parse(lbl_Visor.Text);
            lbl_Visor.Text = "";
            lbl_operacao.Text = "+";


        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            Operacao_Selecionada = Operacao.Subtracao;
            Valor = decimal.Parse(lbl_Visor.Text);
            lbl_Visor.Text = "";
            lbl_operacao.Text = "-";

        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            Operacao_Selecionada = Operacao.Multiplicacao;
            Valor = decimal.Parse(lbl_Visor.Text);
            lbl_Visor.Text = "";
            lbl_operacao.Text = "*";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            Operacao_Selecionada = Operacao.Divisao;
            Valor = decimal.Parse(lbl_Visor.Text);
            lbl_Visor.Text = "";
            lbl_operacao.Text = "/";

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (Operacao_Selecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + decimal.Parse(lbl_Visor.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - decimal.Parse(lbl_Visor.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * decimal.Parse(lbl_Visor.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / decimal.Parse(lbl_Visor.Text);
                    break;
            }
            lbl_Visor.Text = Resultado.ToString();
            lbl_operacao.Text = "=";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text += "0";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (!lbl_Visor.Text.Contains(","))
                lbl_Visor.Text += ",";
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            lbl_Visor.Text = "";
        }

        private void lbl_operacao_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "";
        }
    }

}
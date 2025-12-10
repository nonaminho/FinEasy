namespace FinEasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            try
            {            
                double ValorInicial = double.Parse(text_ValorIni.Text);
                double TaxaAnual = double.Parse(text_taxa.Text);
                int PeriodoAnos = int.Parse(text_Periodo.Text);
                double InvestimentoMensal = double.Parse(text_Investimento.Text);
                double Inflacao = double.Parse(text_Infla.Text);

                double TaxaMensal = Math.Pow(1 + TaxaAnual / 100, 1.0 / 12) - 1;

                for (int i =0; i< PeriodoAnos * 12; i++)
                {
                    ValorInicial = (ValorInicial + InvestimentoMensal) * (1 + TaxaMensal);
                }
                double ValorAjustadoInflacao = ValorInicial / Math.Pow(1 + Inflacao / 100, PeriodoAnos);
                MessageBox.Show($"Valor Futuro: {ValorInicial:C2}\nValor Ajustado pela Inflação: {ValorAjustadoInflacao:C2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos em todos os campos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}

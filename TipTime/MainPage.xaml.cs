namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void QuinzeporcBnt_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void VinteporcBnt_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valor = Convert.ToDouble(ValorTotalEntry.Text);
            double porcetagem = e.NewValue;
            double gorjeta = valor * (porcetagem / 100);
            double valorFinal = valor + gorjeta;
            double gorjetaArredondada = Math.Round(gorjeta);
            double valorArredondado = Math.Round(valorFinal);
            PorcetagemGorjetaLabel.Text = porcetagem.ToString();

            ValorGorjetaLabel.Text = $"Gorjeta: {gorjeta:C}";
            ValorTotalLabel.Text = $"Total com Gorgejta: {valorFinal}";
        }

        private void ArrendodarParaMenos_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(ValorTotalEntry.Text);
            double arredondado = Math.Floor(valor / 10 ) * 10;
            ValorTotalEntry.Text = arredondado.ToString();
        }

        private void ArredondarParaMais_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(ValorTotalEntry.Text);
            double arrendondado = Math.Ceiling(valor / 10) * 10;
            ValorTotalEntry.Text = arrendondado.ToString();
        }


    }

}

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

        private void ArredondarParaMais_Clicked(object sender, EventArgs e)
        {

        }

        private void ArrendodarParaMenos_Clicked(object sender, EventArgs e)
        {

        }
        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valor = Convert.ToDouble(ValorTotalEntry.Text);
            double porcetagem = e.NewValue;
            double gorjeta = valor * (porcetagem / 100);
            double valorFinal = valor + gorjeta;

            ValorGorjetaLabel.Text = $"Gorjeta: {gorjeta:C}";
            ValorTotalLabel.Text = $"Total com Gorgejta: {valorFinal}";
        }
    }

}

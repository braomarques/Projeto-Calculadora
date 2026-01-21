namespace Calculadora
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Somar(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(inp_v1.Text);
            double v2 = Convert.ToDouble(inp_v2.Text);
            string operador = picker_operador.SelectedItem.ToString();

            switch (operador)
            {
                case "Soma": DisplayAlert("Resultado",$"O resultado é: {v1+v2}","Fechar"); break;
                case "Subtração": DisplayAlert("Resultado", $"O resultado é: {v1-v2}", "Fechar"); break;
                case "Multiplicação": DisplayAlert("Resultado", $"O resultado é: {v1*v2}", "Fechar"); break;
                case "Divisão": DisplayAlert("Resultado", $"O resultado é: {v1/v2}", "Fechar"); break;
                default: DisplayAlert("Erro", "Como você quebrou meu código?", "Atumalaca"); break;


            }
        }
    }
}

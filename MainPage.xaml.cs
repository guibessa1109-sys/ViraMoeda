namespace Vira_Moeda
{
    public partial class MainPage : ContentPage
    {
        int vitorias = 0;
        int derrotas = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarMoedaButton_Clicked(object sender, EventArgs e)
        {

            Random moeda = new Random();

            int LadoSorteado = moeda.Next(2);

            ResultadoJogo.Text = LadoSorteado.ToString();

            if (Seletor.SelectedItem == "Cara")
            {
                if (LadoSorteado == 0)
                {
                    vitorias++;
                    ResultadoJogo.Text = "Deu cara, você acertou!";
                    VitoriasLabel.Text = $"Vitórias : {vitorias}";
                }
                else
                {
                    derrotas++;
                    ResultadoJogo.Text = "Deu coroa, você errou!";
                    DerrotasLabel.Text = $"Derrotas : {derrotas}";
                }
            }
            if (Seletor.SelectedItem == "Coroa")
            {
                if (LadoSorteado == 1)
                {
                    vitorias++;
     
                    ResultadoJogo.Text = "Deu Coroa, você acertou!";
                    VitoriasLabel.Text = $"Vitórias : {vitorias}";
                }
                else
                {
                    derrotas++;
                   DerrotasLabel.Text = $"Derrotas : {derrotas}";
                    ResultadoJogo.Text = "Deu cara, você errou!"; 

                }
            }
            


        }
    }
}

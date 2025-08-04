using Windows.UI.Xaml.Controls;

namespace Xbox_UWP_App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            // Exemple : Ajouter un texte dynamique
            var textBlock = new TextBlock
            {
                Text = "Bienvenue sur Xbox !",
                FontSize = 32,
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center
            };
            
            this.Content = textBlock;
        }
    }
}

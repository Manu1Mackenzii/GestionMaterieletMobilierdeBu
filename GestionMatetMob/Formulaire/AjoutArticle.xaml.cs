using System.Windows;

namespace GestionMatetMob.Formulaire
{
    /// <summary>
    /// Logique d'interaction pour AjoutArticle.xaml
    /// </summary>
    public partial class AjoutArticle : Window
    {
        public AjoutArticle()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void btAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

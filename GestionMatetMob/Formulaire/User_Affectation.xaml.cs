using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionMatetMob;

namespace GestionMatetMob.Formulaire
{
    /// <summary>
    /// Logique d'interaction pour User_Affectation.xaml
    /// </summary>
    public partial class User_Affectation : UserControl
    {
        private Gestion_MaterielEntitie GM;
        public User_Affectation()
        {
            InitializeComponent();
            GM = new Gestion_MaterielEntitie();
            CbNomArticle.DataContext = GM.Articles.ToList();
            CbNomArticle.DisplayMemberPath = "libelle_article";
            CbNomArticle.SelectedValuePath = "code_article";

            CbNomService.DataContext = GM.Services.ToList();
            CbNomService.DisplayMemberPath = "nom_service";
            CbNomService.SelectedValuePath = "code_service";
        }

        private void btQuitter_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class Gestion_MaterielEntitie
    {
        public object Articles { get; internal set; }
        public object Services { get; internal set; }
    }
}

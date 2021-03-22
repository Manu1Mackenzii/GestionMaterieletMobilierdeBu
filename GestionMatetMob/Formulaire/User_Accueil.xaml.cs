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

namespace GestionMatetMob.Formulaire
{
    /// <summary>
    /// Logique d'interaction pour User_Accueil.xaml
    /// </summary>
    

    public partial class User_Accueil : UserControl
    {
        private static User_Accueil UAccueil;

        public static User_Accueil Instance
        {
            get
            {
                if (UAccueil == null)
                {
                    UAccueil = new User_Accueil();
                }
                return UAccueil;
            }
        }
        public User_Accueil()
        {
            InitializeComponent();
        }
    }
}

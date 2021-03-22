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
using System.Data.SqlClient;
using System.Windows.Shapes;
using System.Configuration;



namespace GestionMatetMob.Formulaire
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if (VerifyUtilisateurs(NomTb.Text, MdpTb.Password))
            {
                MessageBox.Show("Connecté(e)", "Félicitation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Pseudo ou mot de passe incorrect", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool VerifyUtilisateurs(string Nom_util, string Mot_de_passe)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from Utilisateurs where Nom_util='" + NomTb + "' and Mot_de_passe='" + MdpTb + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


      

        private void EffBt_Click(object sender, RoutedEventArgs e)
        {
            NomTb.Clear();
            MdpTb.Clear();
            NomTb.Focus();
        }

       
    }
}







/*
 
     
     
   SqlConnection conn = new  SqlConnection(@"Data Source=MCCKENZII-IT-WO\SQLEXPRESS;Initial Catalog=Gestion_Materiel;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select *   from Utilisateurs where Nom_util = '" + UtilText+ "' && Mot_de_passe = '" + MdpText+ "'" ,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") 
            {
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.Show();

            }
            else
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
            UtilText.Clear();
            MdpText.Clear();
            UtilText.Focus();    
     
     
     
 */

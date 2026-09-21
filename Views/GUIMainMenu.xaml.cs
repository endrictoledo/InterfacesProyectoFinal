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
using System.Windows.Shapes;

namespace InterfacesProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para GUIMainMenu.xaml
    /// </summary>
    public partial class GUIMainMenu : Window
    {
        public GUIMainMenu()
        {
            InitializeComponent();
        }

        private void BtnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void BtnCerrarMenu_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsOverlay.Visibility = Visibility.Collapsed;
        }

        private void BtnAbrirSettings_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsOverlay.Visibility = Visibility.Visible;
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsOverlay.Visibility = Visibility.Collapsed;
            MenuProfileOverlay.Visibility = Visibility.Visible;
        }
        private void BtnLanguages_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsOverlay.Visibility = Visibility.Collapsed;
            MenuLanguagesOverlay.Visibility = Visibility.Visible;
        }
        private void BtnCerrarMenuLanguages_Click(object sender, RoutedEventArgs e)
        {
            MenuLanguagesOverlay.Visibility = Visibility.Collapsed;
            MenuSettingsOverlay.Visibility = Visibility.Visible;
        }
        private void BtnCerrarMenuProfile_Click(object sender, RoutedEventArgs e)
        {
            MenuProfileOverlay.Visibility = Visibility.Collapsed;
            MenuSettingsOverlay.Visibility = Visibility.Visible;
        }

    }

}

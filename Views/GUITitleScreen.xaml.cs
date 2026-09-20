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

namespace InterfacesProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para GUITitleScreen.xaml
    /// </summary>
    public partial class GUITitleScreen : Window
    {
        public GUITitleScreen()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAbrirIdiomas_Click(object sender, RoutedEventArgs e)
        {
            MenuLanguagesOverlay.Visibility = Visibility.Visible;
        }

        private void BtnCerrarMenu_Click(object sender, RoutedEventArgs e)
        {
            MenuLanguagesOverlay.Visibility = Visibility.Collapsed;
        }

        private void BtnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

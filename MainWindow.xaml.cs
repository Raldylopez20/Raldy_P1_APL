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
using Raldy_P1_APL.UI.Registros;
using Raldy_P1_APL.UI.

namespace Raldy_P1_APL
{

    /// <Summary>
    ///Interaction logic for MainWindow.xaml
    /// </Summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rCuidadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cCiudades rCiudades = new cCiudades();
            cCiudades.Show();
        }

        private void cCuidadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cCiudades cCiudades = new cCiudades();
            cCiudades.Show();
        }
    }
}

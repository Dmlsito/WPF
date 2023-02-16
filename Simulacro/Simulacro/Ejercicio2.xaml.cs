using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace Simulacro
{
    /// <summary>
    /// Lógica de interacción para Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
           
        }

        private void click(object sender, RoutedEventArgs e) {

            if (CheckName.IsChecked != true)
                lblName.Visibility = Visibility.Collapsed;

            else
                lblName.Visibility = Visibility.Visible;

            if (CheckApellido.IsChecked != true)
                lblApellido.Visibility = Visibility.Collapsed;
            
            else
                lblApellido.Visibility = Visibility.Visible;
        }
    }
}

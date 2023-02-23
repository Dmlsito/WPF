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

namespace Repaso2
{
    /// <summary>
    /// Lógica de interacción para Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
           
        }

        
      
        private void click(object sender, RoutedEventArgs e)
        {
            if (checkBox3.IsChecked == true)
            {
                text3.Visibility = Visibility.Visible;
            }


            else
            {
                text3.Visibility = Visibility.Collapsed;
            }
            if (checkBox2.IsChecked == true)
            {
                text2.Visibility = Visibility.Visible;
            }


            else
            {
                text2.Visibility = Visibility.Hidden;
            }
            if (checkBox1.IsChecked == true)
            {
                text1.Visibility = Visibility.Visible;
            }


            else if (checkBox1.IsChecked == false)
            {
                text1.Visibility = Visibility.Hidden;
            }

        }

       
    }
}

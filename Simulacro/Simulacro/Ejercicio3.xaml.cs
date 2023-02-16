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

namespace Simulacro
{
    /// <summary>
    /// Lógica de interacción para Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnstop_Click(object sender, RoutedEventArgs e)
        {
            //Esto es como si estuviesemos seteando el stop de la progressBar a true
            Progress.IsIndeterminate = false;
        }

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            Progress.IsIndeterminate = true;
        }
    }
}

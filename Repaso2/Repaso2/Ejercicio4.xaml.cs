using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
       
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {

            progressBar.Value += 1;
        }
    }
}

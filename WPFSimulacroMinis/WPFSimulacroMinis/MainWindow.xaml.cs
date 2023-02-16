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

namespace WPFSimulacroMinis
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ventana = new Ejercicio1();
            ventana.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ventana = new Ejercicio2();
            ventana.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ventana=new Ejercicio3();
            ventana.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }
    }
}

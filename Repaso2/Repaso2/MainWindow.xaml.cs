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

namespace Repaso2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ControlesHijo ventana1 = new ControlesHijo();
            ventana1.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            DeclaracionExplicita ventana2 = new DeclaracionExplicita();
            ventana2.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            DataBinding ventana3 = new DataBinding();
            ventana3.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ventana4 = new Ejercicio4();
            ventana4.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ventana5 = new Ejercicio5();
            ventana5.Show();
        }
    }
}

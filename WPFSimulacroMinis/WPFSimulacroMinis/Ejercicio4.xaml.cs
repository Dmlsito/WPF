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

namespace WPFSimulacroMinis
{
    /// <summary>
    /// Lógica de interacción para Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
            cb.Items.Add("Saludar");
            cb.Items.Add("Despedir");
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb.SelectedItem.Equals("Saludar"))
            {
                Hola hola = new Hola();
                frame.Navigate(hola);
            }
            if (cb.SelectedItem.Equals("Despedir"))
            {
                Ciao ciao = new Ciao();
                frame.Navigate(ciao);
            }
        }
    }
}

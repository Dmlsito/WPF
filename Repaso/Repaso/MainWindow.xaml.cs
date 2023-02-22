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

namespace Repaso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String sourceEspana = "C:\\Users\\usuario\\Desktop\\2 DAW/espana.jpg";
        private String sourceFrancia = "C:\\Users\\usuario\\Desktop\\2 DAW/francia.jpg";
        private String sourceItalia = "C:\\Users\\usuario\\Desktop\\2 DAW/italia.png";

        public MainWindow()
        {
            InitializeComponent();
            listBox.Items.Add("Espana");
            listBox.Items.Add("Francia");
            listBox.Items.Add("Italia");
            border.Visibility = Visibility.Hidden;
            imageBorder.Visibility = Visibility.Hidden;
        }
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedItem.Equals("Espana"))
            {
                image.Source = new BitmapImage(new Uri(sourceEspana));
                border.Visibility = Visibility.Visible;
                imageBorder.Visibility = Visibility.Visible;
                informacion.Text = "Esta es la bandera de Espana";
            }

            if (listBox.SelectedItem.Equals("Francia"))
            {
                image.Source = new BitmapImage(new Uri(sourceFrancia));
                border.Visibility = Visibility.Visible;
                imageBorder.Visibility = Visibility.Visible;
                informacion.Text = "Esta es la bandera de Francia";
            }


            if (listBox.SelectedItem.Equals("Italia"))
            {
                image.Source = new BitmapImage(new Uri(sourceItalia));
                border.Visibility = Visibility.Visible;
                imageBorder.Visibility = Visibility.Visible;
                informacion.Text = "Esta es la bandera de Italia";
            }
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            pagina1.Navigate(page1); 
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            pagina2.Navigate(page2);
        }
    }
}

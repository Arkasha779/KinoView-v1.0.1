using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для GFe.xaml
    /// </summary>
    public partial class GFe : Window
    {
        public GFe()
        {
            InitializeComponent();
        }

        private void ix21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F6 winf12 = new F6();
            winf12.Show();
            Close();
        }

        private void ix22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F11 winf20 = new F11();
            winf20.Show();
            Close();
        }

        private void ix23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F17 winf5 = new F17();
            winf5.Show();
            Close();
        }

        private void bx8_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }
    }
}

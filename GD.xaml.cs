using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для GD.xaml
    /// </summary>
    public partial class GD : Window
    {
        public GD()
        {
            InitializeComponent();
        }

        private void ix7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 winf2 = new F2();
            winf2.Show();
            Close();
        }

        private void ix8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F6 winf12 = new F6();
            winf12.Show();
            Close();
        }

        private void ix9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F5 winf11 = new F5();
            winf11.Show();
            Close();
        }

        private void ix10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F12 winf15 = new F12();
            winf15.Show();
            Close();
        }

        private void ix11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F9 winf19 = new F9();
            winf19.Show();
            Close();
        }

        private void ix12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F10 winf22 = new F10();
            winf22.Show();
            Close();
        }

        private void bx4_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }
    }
}

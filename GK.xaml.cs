using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для GK.xaml
    /// </summary>
    public partial class GK : Window
    {
        public GK()
        {
            InitializeComponent();
        }

        private void ix17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 winf4 = new F16();
            winf4.Show();
            Close();
        }

        private void ix18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F15 winf25 = new F15();
            winf25.Show();
            Close();
        }

        private void ix19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F5 winf11 = new F5();
            winf11.Show();
            Close();
        }

        private void ix20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F18 winf16 = new F18();
            winf16.Show();
            Close();
        }

        private void bx7_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }
    }
}

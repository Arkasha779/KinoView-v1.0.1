using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для GF.xaml
    /// </summary>
    public partial class GF : Window
    {
        public GF()
        {
            InitializeComponent();
        }

        private void ix1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F11 winf20 = new F11();
            winf20.Show();
            Close();
        }

        private void ix2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F6 winf12 = new F6();
            winf12.Show();
            Close();
        }

        private void ix3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F1 winf9 = new F1();
            winf9.Show();
            Close();
        }

        private void ix4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F12 winf15 = new F12();
            winf15.Show();
            Close();
        }

        private void ix5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F19 winx3 = new F19();
            winx3.Show();
            Close();
        }

        private void ix6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F3 winf7 = new F3();
            winf7.Show();
            Close();
        }

        private void bx1_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }
    }
}

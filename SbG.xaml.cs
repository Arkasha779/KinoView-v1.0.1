using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbG.xaml
    /// </summary>
    public partial class SbG : Window
    {
        public SbG()
        {
            InitializeComponent();
        }

        private void if19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F9 winf19 = new F9();
            winf19.Show();
            Close();
        }

        private void if20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F11 winf20 = new F11();
            winf20.Show();
            Close();
        }

        private void if21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F7 winf14 = new F7();
            winf14.Show();
            Close();
        }

        private void if22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F22 winf21 = new F22();
            winf21.Show();
            Close();
        }

        private void if23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F10 winf22 = new F10();
            winf22.Show();
            Close();
        }

        private void if24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F13 winf23 = new F13();
            winf23.Show();
            Close();
        }

        private void bb18_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}

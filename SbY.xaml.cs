using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbY.xaml
    /// </summary>
    public partial class SbY : Window
    {
        public SbY()
        {
            InitializeComponent();
        }

        private void if13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F1 winf9 = new F1();
            winf9.Show();
            Close();
        }

        private void if14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F3 winf7 = new F3();
            winf7.Show();
            Close();
        }

        private void if15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F7 winf14 = new F7();
            winf14.Show();
            Close();
        }

        private void if16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F12 winf15 = new F12();
            winf15.Show();
            Close();
        }

        private void if17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F18 winf16 = new F18();
            winf16.Show();
            Close();
        }

        private void if18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F21 winf17 = new F21();
            winf17.Show();
            Close();
        }

        private void bb13_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}

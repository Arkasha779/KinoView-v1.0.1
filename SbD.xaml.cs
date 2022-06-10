using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbD.xaml
    /// </summary>
    public partial class SbD : Window
    {
        public SbD()
        {
            InitializeComponent();
        }

        private void if7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F1 winf9 = new F1();
            winf9.Show();
            Close();
        }

        private void if8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 winf2 = new F2();
            winf2.Show();
            Close();
        }

        private void if9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F3 winf7 = new F3();
            winf7.Show();
            Close();
        }

        private void if10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F4 winf10 = new F4();
            winf10.Show();
            Close();
        }

        private void if11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F5 winf11 = new F5();
            winf11.Show();
            Close();
        }

        private void if12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F6 winf12 = new F6();
            winf12.Show();
            Close();
        }

        private void bb8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }
    }
}

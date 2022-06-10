using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbR.xaml
    /// </summary>
    public partial class SbR : Window
    {
        public SbR()
        {
            InitializeComponent();
        }

        private void if1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F8 winf3 = new F8();
            winf3.Show();
            Close();
        }

        private void if2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 winf4 = new F16();
            winf4.Show();
            Close();
        }

        private void if3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F17 winf5 = new F17();
            winf5.Show();
            Close();
        }

        private void if4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 winf2 = new F2();
            winf2.Show();
            Close();
        }

        private void if5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F14 winf6 = new F14();
            winf6.Show();
            Close();
        }

        private void if6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F3 winf7 = new F3();
            winf7.Show();
            Close();
        }

        private void bb1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }
    }
}

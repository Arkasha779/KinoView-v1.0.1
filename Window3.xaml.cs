using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }

        private void i1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void i2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void i3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void i4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void i5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }

        private void i6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
            Close();
        }
    }
}

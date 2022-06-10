using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }

        private void is1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window6 win6 = new Window6();
            win6.Show();
            Close();
        }
    }
}

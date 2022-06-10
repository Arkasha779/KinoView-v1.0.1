using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbC.xaml
    /// </summary>
    public partial class SbC : Window
    {
        public SbC()
        {
            InitializeComponent();
        }

        private void if31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F7 winf14 = new F7();
            winf14.Show();
            Close();
        }

        private void if32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F8 winf3 = new F8();
            winf3.Show();
            Close();
        }

        private void if33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F15 winf25 = new F15();
            winf25.Show();
            Close();
        }

        private void if34_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F21 winf17 = new F21();
            winf17.Show();
            Close();
        }

        private void if35_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F13 winf23 = new F13();
            winf23.Show();
            Close();
        }

        private void if36_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 winf2 = new F2();
            winf2.Show();
            Close();
        }

        private void bb26_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}

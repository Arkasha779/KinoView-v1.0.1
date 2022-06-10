using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для GT.xaml
    /// </summary>
    public partial class GT : Window
    {
        public GT()
        {
            InitializeComponent();
        }

        private void ix13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F4 winf10 = new F4();
            winf10.Show();
            Close();
        }

        private void ix14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F15 winf25 = new F15();
            winf25.Show();
            Close();
        }

        private void ix15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F5 winf11 = new F5();
            winf11.Show();
            Close();
        }

        private void ix16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F19 winx3 = new F19();
            winx3.Show();
            Close();
        }



        private void bx6_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }
    }
}

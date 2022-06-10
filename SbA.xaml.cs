using System.Windows;
using System.Windows.Input;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbA.xaml
    /// </summary>
    public partial class SbA : Window
    {
        public SbA()
        {
            InitializeComponent();
        }

        private void if25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F15 winf25 = new F15();
            winf25.Show();
            Close();
        }

        private void if26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F21 winf17 = new F21();
            winf17.Show();
            Close();
        }

        private void if27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F1 winf9 = new F1();
            winf9.Show();
            Close();
        }

        private void if28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F13 winf23 = new F13();
            winf23.Show();
            Close();
        }

        private void if29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 winf2 = new F2();
            winf2.Show();
            Close();
        }

        private void if30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F3 winf7 = new F3();
            winf7.Show();
            Close();
        }

        private void bb24_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}

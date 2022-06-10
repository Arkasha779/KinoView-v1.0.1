using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F5.xaml
    /// </summary>
    public partial class F5 : Window
    {
        public F5()
        {
            InitializeComponent();
        }

        private void bb11_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void bb11с_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }

        private void bb11с1_Click(object sender, RoutedEventArgs e)
        {
            GT winx6 = new GT();
            winx6.Show();
            Close();
        }

        private void bb11с2_Click(object sender, RoutedEventArgs e)
        {
            GK winx7 = new GK();
            winx7.Show();
            Close();
        }
    }
}

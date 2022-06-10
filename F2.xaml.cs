using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F2.xaml
    /// </summary>
    public partial class F2 : Window
    {
        public F2()
        {
            InitializeComponent();
        }

        private void bb2_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void bb2c_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void bb2c1_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }

        private void bb2c2_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }
    }
}

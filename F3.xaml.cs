using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F3.xaml
    /// </summary>
    public partial class F3 : Window
    {
        public F3()
        {
            InitializeComponent();
        }

        private void bb7_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void bb7с_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void bb7с1_Click(object sender, RoutedEventArgs e)
        {
            SbY winf12 = new SbY();
            winf12.Show();
            Close();
        }

        private void bb7с2_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }
    }
}

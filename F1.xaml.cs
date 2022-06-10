using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F1.xaml
    /// </summary>
    public partial class F1 : Window
    {
        public F1()
        {
            InitializeComponent();
        }

        private void bb9_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void bb9c_Click(object sender, RoutedEventArgs e)
        {
            SbY winf13 = new SbY();
            winf13.Show();
            Close();
        }

        private void bb9c1_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }
    }
}

using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F12.xaml
    /// </summary>
    public partial class F12 : Window
    {
        public F12()
        {
            InitializeComponent();
        }

        private void bb15_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }

        private void bb15c_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }
    }
}

using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F19.xaml
    /// </summary>
    public partial class F19 : Window
    {
        public F19()
        {
            InitializeComponent();
        }

        private void bx2_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }

        private void bx2c_Click(object sender, RoutedEventArgs e)
        {
            GT winx6 = new GT();
            winx6.Show();
            Close();
        }
    }
}

using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F6.xaml
    /// </summary>
    public partial class F6 : Window
    {
        public F6()
        {
            InitializeComponent();
        }

        private void bb12_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }

        private void bb12с_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }

        private void bb12с1_Click(object sender, RoutedEventArgs e)
        {
            GFe winx8 = new GFe();
            winx8.Show();
            Close();
        }
    }
}

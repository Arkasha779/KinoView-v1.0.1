using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для Genre.xaml
    /// </summary>
    public partial class Genre : Window
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void bl1_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }

        private void bl2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bl7_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }

        private void bl3_Click(object sender, RoutedEventArgs e)
        {
            GT winx6 = new GT();
            winx6.Show();
            Close();
        }

        private void bl4_Click(object sender, RoutedEventArgs e)
        {
            GK winx7 = new GK();
            winx7.Show();
            Close();
        }

        private void bl5_Click(object sender, RoutedEventArgs e)
        {
            GFe winx8 = new GFe();
            winx8.Show();
            Close();
        }

        private void bl6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bx4_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            Close();
        }
    }
}

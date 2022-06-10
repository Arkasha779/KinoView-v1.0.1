using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void bf1_Click(object sender, RoutedEventArgs e)
        {
            SbY winf13 = new SbY();
            winf13.Show();
            Close();
        }

        private void bf2_Click(object sender, RoutedEventArgs e)
        {
            Genre winx1 = new Genre();
            winx1.Show();
            Close();
        }



        private void bf4_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }

        private void bf5_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }



        private void b4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }
    }
}

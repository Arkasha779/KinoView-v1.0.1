using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F15.xaml
    /// </summary>
    public partial class F15 : Window
    {
        public F15()
        {
            InitializeComponent();
        }

        private void bb25_Click(object sender, RoutedEventArgs e)
        {
            GT winx6 = new GT();
            winx6.Show();
            Close();
        }

        private void bb25c_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }

        private void bb25с1_Click(object sender, RoutedEventArgs e)
        {
            GK winx7 = new GK();
            winx7.Show();
            Close();
        }
    }
}

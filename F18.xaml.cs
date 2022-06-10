using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F18.xaml
    /// </summary>
    public partial class F18 : Window
    {
        public F18()
        {
            InitializeComponent();
        }

        private void bb16_Click(object sender, RoutedEventArgs e)
        {
            SbY winf13 = new SbY();
            winf13.Show();
            Close();
        }

        private void bb16с_Click(object sender, RoutedEventArgs e)
        {
            GK winx7 = new GK();
            winx7.Show();
            Close();
        }
    }
}

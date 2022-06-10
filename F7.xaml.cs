using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F7.xaml
    /// </summary>
    public partial class F7 : Window
    {
        public F7()
        {
            InitializeComponent();
        }

        private void bb14_Click(object sender, RoutedEventArgs e)
        {
            SbY winf13 = new SbY();
            winf13.Show();
            Close();
        }

        private void bb14c_Click(object sender, RoutedEventArgs e)
        {
            SbG winf18 = new SbG();
            winf18.Show();
            Close();
        }

        private void bb14c1_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }
    }
}

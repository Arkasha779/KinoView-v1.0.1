using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F21.xaml
    /// </summary>
    public partial class F21 : Window
    {
        public F21()
        {
            InitializeComponent();
        }

        private void bb17_Click(object sender, RoutedEventArgs e)
        {
            SbY winf13 = new SbY();
            winf13.Show();
            Close();
        }

        private void bb17c_Click(object sender, RoutedEventArgs e)
        {
            SbA winf24 = new SbA();
            winf24.Show();
            Close();
        }

        private void bb17c1_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }
    }
}

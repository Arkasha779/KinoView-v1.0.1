using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F13.xaml
    /// </summary>
    public partial class F13 : Window
    {
        public F13()
        {
            InitializeComponent();
        }

        private void bb23_Click(object sender, RoutedEventArgs e)
        {
            SbG winf18 = new SbG();
            winf18.Show();
            Close();
        }

        private void bb23c_Click(object sender, RoutedEventArgs e)
        {
            SbA winf24 = new SbA();
            winf24.Show();
            Close();
        }

        private void bb23c1_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }
    }
}

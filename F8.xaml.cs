using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F8.xaml
    /// </summary>
    public partial class F8 : Window
    {
        public F8()
        {
            InitializeComponent();
        }

        private void bb3_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void bb3c_Click(object sender, RoutedEventArgs e)
        {
            SbC winf26 = new SbC();
            winf26.Show();
            Close();
        }
    }
}

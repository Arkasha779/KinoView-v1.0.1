using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F4.xaml
    /// </summary>
    public partial class F4 : Window
    {
        public F4()
        {
            InitializeComponent();
        }

        private void bb10_Click(object sender, RoutedEventArgs e)
        {
            SbD winf8 = new SbD();
            winf8.Show();
            Close();
        }

        private void bb10с_Click(object sender, RoutedEventArgs e)
        {
            GT winx6 = new GT();
            winx6.Show();
            Close();
        }
    }
}

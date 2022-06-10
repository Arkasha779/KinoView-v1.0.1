using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F16.xaml
    /// </summary>
    public partial class F16 : Window
    {
        public F16()
        {
            InitializeComponent();
        }

        private void bb4_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void bb4с_Click(object sender, RoutedEventArgs e)
        {
            GK winx7 = new GK();
            winx7.Show();
            Close();
        }
    }
}

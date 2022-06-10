using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F14.xaml
    /// </summary>
    public partial class F14 : Window
    {
        public F14()
        {
            InitializeComponent();
        }

        private void bb6_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }
    }
}

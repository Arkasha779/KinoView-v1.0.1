using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F11.xaml
    /// </summary>
    public partial class F11 : Window
    {
        public F11()
        {
            InitializeComponent();
        }

        private void bb20_Click(object sender, RoutedEventArgs e)
        {
            GF winx2 = new GF();
            winx2.Show();
            Close();
        }

        private void bb20c_Click(object sender, RoutedEventArgs e)
        {
            GFe winx8 = new GFe();
            winx8.Show();
            Close();
        }
    }
}

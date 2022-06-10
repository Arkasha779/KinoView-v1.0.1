using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F17.xaml
    /// </summary>
    public partial class F17 : Window
    {
        public F17()
        {
            InitializeComponent();
        }

        private void bb5_Click(object sender, RoutedEventArgs e)
        {
            SbR winf1 = new SbR();
            winf1.Show();
            Close();
        }

        private void bb5с_Click(object sender, RoutedEventArgs e)
        {
            GFe winx8 = new GFe();
            winx8.Show();
            Close();
        }
    }
}

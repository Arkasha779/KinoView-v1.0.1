using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F22.xaml
    /// </summary>
    public partial class F22 : Window
    {
        public F22()
        {
            InitializeComponent();
        }

        private void bb21_Click(object sender, RoutedEventArgs e)
        {
            SbG winf18 = new SbG();
            winf18.Show();
            Close();
        }
    }
}

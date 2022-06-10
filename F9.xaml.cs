using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F9.xaml
    /// </summary>
    public partial class F9 : Window
    {
        public F9()
        {
            InitializeComponent();
        }

        private void bb19_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }
    }
}

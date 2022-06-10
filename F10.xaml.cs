using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для F10.xaml
    /// </summary>
    public partial class F10 : Window
    {
        public F10()
        {
            InitializeComponent();
        }

        private void bb22_Click(object sender, RoutedEventArgs e)
        {
            GD winx5 = new GD();
            winx5.Show();
            Close();
        }
    }
}

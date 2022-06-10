using System.Windows;

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }


        private void b12_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "admin" && pb1.Password == "123")
            {
                Window7 win7 = new Window7();
                win7.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();
        }
    }
}

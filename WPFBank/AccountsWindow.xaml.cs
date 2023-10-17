using System.Windows;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {
        public AccountsWindow()
        {
            InitializeComponent();

            string name = "Anders";
            string lastname = "Andersson";

            lblWelcome.Content += $" {name}";

        }

        private void btnLogOutAdmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

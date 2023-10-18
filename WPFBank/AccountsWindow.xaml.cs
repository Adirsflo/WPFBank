using System.Windows;
using WPFBank.Methods;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {
        public AccountsWindow(User user)
        {
            InitializeComponent();

            if (user.GetType() == typeof(Client))
            {
                Client client = (Client)user;
                lblWelcome.Content += client.GetInfo();
            }

        }

        private void btnLogOutAdmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

using System.Windows;
using System.Windows.Input;
using WPFBank.Manager_Class;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void blkNewAccount_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (bxAdminLogin.IsChecked == true)
            {
                if (txtUsername.Text.ToLower() == "admin" && pbxPassword.Password == "Password")
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("The username and password doesn't match. Please try again!", "Invalid Login");
                }
            }
            else if (bxAdminLogin.IsChecked == false)
            {
                bool isMatchingInput = false;

                if (UserManager.clientList.Count == 0)
                {
                    MessageBox.Show("There is no registerd account. Please create an account!", "Invalid Login");
                }
                else
                {
                    foreach (User user in UserManager.clientList)
                    {
                        if (txtUsername.Text.ToLower() == user.Username.ToLower() && pbxPassword.Password == user.Password)
                        {
                            isMatchingInput = true;
                            AccountsWindow accountsWindow = new AccountsWindow(user);
                            accountsWindow.Show();
                            Close();
                        }
                    }
                    if (isMatchingInput = false)
                    {
                        MessageBox.Show("The username and password doesn't match. Please try again!", "Invalid Login");
                    }
                }
            }
        }
    }
}

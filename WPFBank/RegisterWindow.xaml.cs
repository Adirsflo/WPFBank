using System.Windows;
using WPFBank.Manager_Class;
using WPFBank.Methods;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        MainWindow _mainWindow = new MainWindow();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            Close();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            string newUsername = txtRegisterUsername.Text;
            string newFirstName = txtRegisterFirstName.Text;
            string newLastName = txtRegisterLastName.Text;
            string newPassword = txtRegisterPassword.Text;
            string newConfirmPassword = txtConfirmPassword.Text;

            if (newUsername != "" && newFirstName != "" && newLastName != "")
            {
                if (newPassword == newConfirmPassword)
                {
                    // Kalla på listan
                    // Lägg till användaren i listan och spara informationen
                    Client newClient = new(newUsername, newPassword);

                    newClient.FirstName = newFirstName;
                    newClient.LastName = newLastName;

                    UserManager.clientList.Add(newClient);

                    MessageBox.Show("Successfully registered new user! Welcome!", "New account created");
                    _mainWindow.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("The password doesn't match. Try again!", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Warning");
            }
        }
    }
}

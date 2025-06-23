using BusinessObjects;
using Services;
using System.Windows;

namespace WPFApp
{
    public partial class LoginWindow : Window
    {
        private readonly IAccountService iAccountService;

        public LoginWindow(IAccountService accountService)
        {
            InitializeComponent();
            iAccountService = accountService;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
           AccountMember account = iAccountService.GetAccountMember(txtUser.Text);

            if (account != null && account.MemberPassword.Equals(txtPass.Password)
                && account.MemberRole == 1)
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

            }
            else
            {
                MessageBox.Show("You are not permission");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

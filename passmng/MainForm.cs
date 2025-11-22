using System.Data.SQLite;
using System.Security;

namespace passmng
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var loginPage = new LoginPageControl();
            loginPage.Dock = DockStyle.Fill;

            loginPage.LoginSucceeded += OnLoginSucceeded;

            LoadScreen(loginPage);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadScreen(UserControl screen)
        {
            panelContainer.Controls.Clear();  
            screen.Dock = DockStyle.Fill;     
            panelContainer.Controls.Add(screen);
        }

        public void ShowLoginPage()
        {
            var loginPage = new LoginPageControl();
            loginPage.Dock = DockStyle.Fill;
            loginPage.LoginSucceeded += OnLoginSucceeded;
            LoadScreen(loginPage);
        }
        private void OnLoginSucceeded(SecureString pwd)
        {
            var cryptifyApp = new CryptifyAppControl(pwd);
            cryptifyApp.Dock = DockStyle.Fill;
            LoadScreen(cryptifyApp);
        }

        public void LoadUserControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

        public void ShowSignUpPage()
        {
            var signUp = new SignUpControl();
            signUp.Dock = DockStyle.Fill;

            signUp.AccountCreated += () =>
            {
                ShowLoginPage();
            };
            
            signUp.BackRequested += () =>
            {
                ShowLoginPage(); 
            };

            LoadScreen(signUp);
        }
    }
}

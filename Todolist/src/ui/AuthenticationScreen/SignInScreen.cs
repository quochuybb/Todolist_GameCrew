
using Todolist.src.service;
using Todolist.src.ui.MainMenu;
namespace Todolist;

public partial class SignInScreen : Form
{
    private ConnectDb ConnectDb;
    public SignInScreen(ConnectDb connectDb)
    {
        InitializeComponent();
        ConnectDb = connectDb;
    }

    private void SignIn_Pass_TextBox_Click(object sender, EventArgs e)
    {
        SignIn_Pass_TextBox.Text = "";
    }

    private void SigIn_Email_TextBox_Click(object sender, EventArgs e)
    {
        SignIn_Email_TextBox.Text = "";
    }


    private void SignUp_Button_Click(object sender, EventArgs e)
    {
        SignUpScreen signUpScreen = new SignUpScreen(ConnectDb);
        signUpScreen.ShowDialog();
    }

    private async void SignIn_Button_Click(object sender, EventArgs e)
    {
        var todoService = new TodoService(this.ConnectDb);
        var accountController = new AccountController(todoService);
        var newAccount = new Account()
        {
            Email = SignIn_Email_TextBox.Text,
            Passphrase = SignIn_Pass_TextBox.Text

        };
        if (await accountController.CheckAccountExist(newAccount, false))
        {
            if (await accountController.CheckAccountExist(newAccount,false))
            {
                this.Hide();
                var account = await todoService.GetDataAccountFromDatabase(newAccount.Email, 4);
                UserSession.Instance.SetAccount(account);
                mainMenu mainmenu = new mainMenu(newAccount, todoService);
                mainmenu.Show();
            }
        }
        else
        {
            MessageBox.Show("Wrong Email or Password");
        }
    }
}
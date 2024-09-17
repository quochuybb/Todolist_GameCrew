namespace Todolist;

public partial class SignInScreen : Form
{
    public SignInScreen()
    {

        InitializeComponent();
    }

    private void SigIn_Pass_TextBox_Click(object sender, EventArgs e)
    {
        SigIn_Pass_TextBox.Text = "";
    }

    private void SigIn_Email_TextBox_Click(object sender, EventArgs e)
    {
        SignIn_Email_TextBox.Text = "";
    }


    private void SignUp_Button_Click(object sender, EventArgs e)
    {

    }
}
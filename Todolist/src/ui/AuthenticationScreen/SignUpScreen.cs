using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todolist.src.service;
using Todolist.src.ui.MainMenu;

namespace Todolist
{
    public partial class SignUpScreen : Form
    {
        private ConnectDb connectDb;
        public SignUpScreen(ConnectDb connectDb)
        {
            InitializeComponent();
            this.connectDb = connectDb;
        }
        private async void SignUp_Button_Click(object sender, EventArgs e)
        {
            if (Pass_TextBox.Text != RePass_TexBox.Text)
            {
                MessageBox.Show("Please enter Password again");
                return;
            }
            var todoService = new TodoService(this.connectDb);
            var accountController = new AccountController(todoService);
            var newAccount = new Account()
            {
                Usr = Usr_TextBox.Text,
                Email = Email_TextBox.Text,
                Name = Name_TextBox.Text,
                Passphrase = Pass_TextBox.Text
                
            };
            if (newAccount.Email != null && newAccount.Usr != null)
            {
                await accountController.CreateData(newAccount);
                this.Hide();
                var account = await todoService.GetDataAccountFromDatabase(newAccount.Email, 4);
                UserSession.Instance.SetAccount(account);
                mainMenu mainmenu = new mainMenu();
                mainmenu.Show();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    public class AccountController 
    {
        private TodoService todoService;
        private ValidData validData;
        public AccountController(TodoService todoService) 
        {
            this.todoService = todoService;
            validData = new ValidData();
        }
        public async Task CreateData(Account account)
        {
            if (await CheckAccountExist(account,true))
            {

                MessageBox.Show("Email or Username Exist");
                return;
            }
            try
            { 
                account.Id = await todoService.CountInDatabase<Account>() + 1;
                await todoService.AddDataAccountToDatabase(account);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return; 
            }
        }
        public async Task<bool> CheckAccountExist(Account account, bool sameClass)
        {
            if (sameClass)
            {
                if (await todoService.IsValidDataAccountInDatabase(account, false) >= 0)
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            if (await todoService.IsValidDataAccountInDatabase(account, true) >= 2)
            {
                return true;
            }
            else
            {
                return false;

            }
            
        }
        

    }
}

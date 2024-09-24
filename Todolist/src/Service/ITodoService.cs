using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    public interface ITodoService
    {
        Task<Account> GetDataAccountFromDatabase(string email,int i);
        Task<int> CountInDatabase<T>() where T : class;
        Task AddDataAccountToDatabase<T>(T entity) where T : class;
        Task<int> IsValidDataAccountInDatabase(Account account, bool i);
    }
}

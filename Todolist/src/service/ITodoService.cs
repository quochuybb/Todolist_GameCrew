using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItem>> GetAllAsync();
        Task<Account> GetDataAccountFromDatabase(string email,int i);
        Task<int> CountInDatabase<T>() where T : class;
        Task AddDataAccountToDatabase<T>(T entity) where T : class;
        Task<int> IsValidDataAccountInDatabase(Account account);
        Task<List<TodoItem>> GetTaskByAccountId(int accountId);
        Task AddTodoAsync(TodoItem tasks);
        Task DeleteTodoAsync(int task_id, int acc_id);
    }
}

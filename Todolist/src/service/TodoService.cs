using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
namespace Todolist
{
    public class TodoService : ITodoService
    {
        private readonly ConnectDb _connectDb;
        public TodoService( ConnectDb connect) 
        {
            _connectDb = connect;
        }
        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _connectDb.TodoItem.ToListAsync();
        }
        public async Task<Account> GetDataAccountFromDatabase(string text, int conditionType)
        {
            IQueryable<Account> query = _connectDb.Accounts;
            switch (conditionType)
            {
                case 1:
                    query = query.Where(t => Convert.ToString(t.Id) == text);
                    break;
                case 2:
                    query = query.Where(t => t.Usr == text);
                    break;
                case 3:
                    query = query.Where(t => t.Name == text);
                    break;
                case 4:
                    query = query.Where(t => t.Email == text);
                    break;
                case 5:
                    query = query.Where(t => t.Passphrase == text);
                    break;
            }
            return await query.FirstOrDefaultAsync();
        }
        public async Task AddDataAccountToDatabase<T> (T entity) where T : class
        {
            _connectDb.Add(entity);
            await _connectDb.SaveChangesAsync();
        }
        public async Task<int> CountInDatabase<T>() where T : class
        {
            return await _connectDb.Set<T>().CountAsync();
        }
        public async Task<int> IsValidDataAccountInDatabase(Account account)
        {
            int conditionSuccess = 0;
            var validData = await GetDataAccountFromDatabase(account.Email, 4);
            if (validData != null)
            {
                if (account.Usr == validData.Usr) conditionSuccess += 1;
                if (account.Email == validData.Email) conditionSuccess += 1;
                if (account.Passphrase == validData.Passphrase) conditionSuccess += 1;
            }
            return conditionSuccess;
        }
        public async Task<List<TodoItem>> GetTaskByAccountId(int accountId)
        {
            return await _connectDb.TodoItem
                .Where(t => t.usr_id == accountId)
                .ToListAsync();
        }
        public async Task AddTodoAsync(TodoItem todoItem)
        {
            _connectDb.Add(todoItem);
            await _connectDb.SaveChangesAsync();
        }
        public async Task UpdateTodoAsync(TodoItem task, Account account)
        {
            _connectDb.TodoItem.Update(task);
            await _connectDb.SaveChangesAsync();
        }
        public async Task DeleteTodoAsync(int task_id, int acc_id)
        {
            var item = await _connectDb.TodoItem.FindAsync(task_id);
            if (item != null)
            {
                _connectDb.TodoItem.Remove(item);
                await _connectDb.SaveChangesAsync();
            }
        }
    }
}

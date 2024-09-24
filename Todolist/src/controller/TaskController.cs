using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace Todolist
{
    public class TaskController
    {
        private TodoService todoService;
        public TaskController(TodoService todoService)
        {
            this.todoService = todoService;
        }
        public async Task<List<TodoItem>> LoadData(int id)
        {
            return await todoService.GetTaskByAccountId(id);
        }
        public async Task AddTaskToDatabase(TodoItem todoItem)
        {
            await todoService.AddTodoAsync(todoItem);
        }
    }
}

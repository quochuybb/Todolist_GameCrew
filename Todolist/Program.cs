
using Todolist.src.CRUD_Task;
using Todolist.src.ui.MainMenu;

namespace Todolist
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connect = new ConnectDb();
            ApplicationConfiguration.Initialize();
            Application.Run(new SignInScreen(connect));
        }
    }
}
using Todolist.src.ui.MainMenuScreen;

namespace Todolist
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var connect = new ConnectDb();
            ApplicationConfiguration.Initialize();
            Application.Run(new SignInScreen(connect));
            
            
        }
    }
}
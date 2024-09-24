using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.src.service
{
    public class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();
        public Account LoggedInAccount { get; private set; }
        private UserSession() { }
        public static UserSession Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserSession();
                    }
                    return _instance;
                }
            }
        }
        public void SetAccount(Account account)
        {
            LoggedInAccount = account;
        }
        public void ClearSession()
        {
            LoggedInAccount = null;
        }
    }

}

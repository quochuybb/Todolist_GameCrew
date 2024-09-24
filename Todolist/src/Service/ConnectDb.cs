using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
namespace Todolist
{
    public class ConnectDb : DbContext
    {
        public string connectionString;
        public DbSet<Account> Accounts { get; set; }
        public ConnectDb()
        {
            connectionString = @"Data Source=DESKTOP-FPER9LQ;Initial Catalog=Todolist;Integrated Security=True;Trust Server Certificate=True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

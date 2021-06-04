using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DNC.DAL.Database
{
    public class DatabaseContext : DbContext
    {
        const string connectionString = "Server=azuredbautomotive.database.windows.net;Database=DotNetCoreAssignemnt;Integrated Security=true;Trusted_Connection=False;Encrypt=True;User ID=LalitAkRadadiya;Password=Gateway123;";
        public DatabaseContext() : base() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<ToDoList> ToDoLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

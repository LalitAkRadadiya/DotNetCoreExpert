using DNC.DAL.Database;
using DNC.DAL.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DNC.BAL
{
    public static class Helper
    {

        public static void DependencyHelper(ref IServiceCollection ser)
        {
            ser.AddDbContext<DatabaseContext>();
            ser.AddScoped<IToDoListRepository, ToDoListRepository>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
     new Todo
     {
         Id = 1,
         Title = "Shopping",
         Description = "For Birthday",
         Status = false,
         DueDate = DateTime.Now.AddDays(1)
     },
     new Todo
     {
         Id = 2,
         Title = "Learn C#",
         Description = "In Jump Training",
         Status = false,
         DueDate = DateTime.Now.AddDays(2)
     },
     new Todo
     {
         Id = 3,
         Title = "Learn MSSQL",
         Description = "For Jump Training",
         Status = false,
         DueDate = DateTime.Now.AddDays(2)
     });
        }
    }
}

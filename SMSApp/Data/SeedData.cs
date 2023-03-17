using Microsoft.EntityFrameworkCore;
using SMSApp.Models;

namespace TodoApp.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    studentId = 1,
                    studentName = "Mark",
                    studentAge = 5,
                    //studentAddress = "QC",
                    studentEmailId = "mrkkmbls@gmail.com",
                    
                });


            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    gradeId = 1,
                    gradeName = "ASP.Net"
                });
        }
    }
}

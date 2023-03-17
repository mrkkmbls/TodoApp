using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;
using TodoApp.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace TodoApp.Data
{
    public class TodoDBContext : DbContext
    {
        //define the DB and structure of database will be manage here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            //where is the DB server

            /*
             * 1. server = localhost, ip/ instance of server - MSSQLServer provess
             * 2. How to access this - windows authentications or DB authentication[sa - password]
             * 3. Database name - TodoDB
             * 
             */

            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            string connectionString = @"Server =(localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True;";
            optionsBuilder.UseSqlServer(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Todo>
            //    .ToTable("To_Dos")
            //    .Property("Name")
            //    .HasColumnName("Title")
            //    .HasColumnType("ntext");
            //modelBuilder.Entity<Todo>.Property(Ex);
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedDefaultData();
 
        }

        //tables in db and entities in application mapping
        public DbSet<Todo> Todos { get; set; } //plural or many

        public DbSet<User> Users { get; set; }
    }
}

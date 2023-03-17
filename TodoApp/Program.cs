using TodoApp.Data;
using TodoApp.Repository;
using TodoApp.Repository.InMemory;
using TodoApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Validation framework, DI asp.net core

// DI object is configured by a constructor inject the object defined here 

// if test environment then work with inmemroy object
// else work with database
// asp.net automatically configures objects using DI concept
//builder.Services.AddSingleton<ITodoRepository, TodoDBRepository>();
builder.Services.AddScoped<TodoDBContext, TodoDBContext>();
builder.Services.AddScoped<ITodoRepository, TodoDBRepository>();

//Dependency Injection
//AddSingleton - one object is create for the full application / if working on in memory repository
//AddScoped - a object is create for all request response pipeline
//AddTransient - a new object is created for every request

//configure asp.net the ef library to connect for a db
builder.Services.AddDbContext<TodoDBContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// it identifes the controllers folder list a set of url which it can prepare 
// /home
// /todo/GetAllTodos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=GetAllTodos}/{id?}");

app.Run();

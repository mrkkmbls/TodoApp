using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Repository.MsSQL
{
    public class TodoDBRepository : ITodoRepository
    {
        TodoDBContext _dbContext;

        public TodoDBRepository(TodoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Todo AddTodo(Todo newTodo)
        {
            _dbContext.Add(newTodo);
            //CUD operations u need to save the details -> commit
            _dbContext.SaveChanges();
            return newTodo;
        }

        //delete a todo
        public Todo DeleteTodo(int todoId)
        {
            var todo = GetTodoById(todoId);
            if (todo != null)
            {
                _dbContext.Todos.Remove(todo);
                _dbContext.SaveChanges();
            }
            return todo;
        }

        //view all the data
        public List<Todo> GetAllTodos()
        {
            return _dbContext.Todos.ToList();
        }

        //view specific data using id
        public Todo GetTodoById(int Id)
        {
            //keeps track of it any changes happen to the obejct we can save it automatically
            //discard the default behavior of EF not to track
            return _dbContext.Todos.AsNoTracking().ToList().FirstOrDefault(t => t.Id == Id);
        }

        public Todo UpdateTodo(int todoId, Todo newTodo)
        {
            _dbContext.Todos.Update(newTodo);
            _dbContext.SaveChanges();
            return newTodo;
        }
    }
}

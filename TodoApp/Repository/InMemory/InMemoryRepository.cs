using TodoApp.Models;

namespace TodoApp.Repository.InMemory
{
    public class InMemoryRepository
    {
        //hold the data in run time and allow to perform CRUD operations
    
        static List<User> userlist = new List<User>();

        static InMemoryRepository()
        {
            userlist.Add(new User(1, "Kim", "kim@gmail.com", "kim123", false));
            userlist.Add(new User(2, "Mark", "mark@gmail.com", "mark123", false));
            userlist.Add(new User(2, "Eduard", "ed@gmail.com", "ed123", false));
        }

        public List<User> GetAllUsers()
        {
            return userlist;
        }

        public User GetUserById(int Id)
        {
            return userlist.FirstOrDefault(x => x.uId == Id);
        }

        public User CreateUser(User newUser)
        {
            newUser.uId = userlist.Max(x => x.uId)+1;
            userlist.Add(newUser);
            return newUser;
        }

        public User UpdateUser(int userId, User newUser) 
        {
            var oldUser = userlist.Find(x => x.uId == userId);
            if (oldUser == null)
                return null;
            userlist.Remove(oldUser);
            userlist.Add(newUser);
            return newUser;
        }

        public User DeleteUser(int userId)
        {
            var oldUser = userlist.Find(x => x.uId == userId);
            if (oldUser == null)
                return null;
            userlist.Remove(oldUser);
            return oldUser;
        }
    }
}

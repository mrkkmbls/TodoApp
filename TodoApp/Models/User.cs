using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TodoApp.Customization;

namespace TodoApp.Models
{
    public class User
    {
        [Key]
        public int uId { get; set; }

        public string uName { get; set; }

        public string uEmail { get; set; }

        public string uPassword { get; set; }

        public bool uStatus { get; set; }

        public List<Todo> Todos { get; set; }

        public User()
        {

        }

        public User(int uId, string uName, string uEmail, string uPassword, bool uStatus)
        {
            this.uId = uId;
            this.uName = uName;
            this.uEmail = uEmail;
            this.uPassword = uPassword;
            this.uStatus = uStatus;
        } 
    }
}

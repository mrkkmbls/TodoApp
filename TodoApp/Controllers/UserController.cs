using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Repository.InMemory;

namespace TodoApp.Controllers
{
    public class UserController : Controller
    {
        InMemoryRepository rep = new InMemoryRepository();

        public IActionResult GetAllUsers()
        {
            var userlist = rep.GetAllUsers();
            return View(userlist);
        }

        public IActionResult DetailUser(int userId)
        {
            var user = rep.GetUserById(userId);
            return View(user);
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                var user = rep.CreateUser(newUser);
                return RedirectToAction("GetAllUsers");
            }
            ViewData["Message"] = "Data is not valid to create the Todo";
            return View();
        }


        [HttpGet]
        public IActionResult UpdateUser(int userId)
        {
            var oldUser = rep.GetUserById(userId);
            return View(oldUser);
        }

        [HttpPost]
        public IActionResult UpdateUser(User newUser) 
        {
            var user = rep.UpdateUser(newUser.uId, newUser);
            return RedirectToAction(controllerName: "User", actionName: "GetAllUsers");
        }

        public IActionResult DeleteUser(int userId)
        {
            var userlist = rep.DeleteUser(userId);
            return RedirectToAction(controllerName: "User", actionName: "GetAllUsers");
        }

    }
}

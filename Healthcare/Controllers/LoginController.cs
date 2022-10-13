using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class LoginController : Controller
    {
        private HealthcareDbContext context;
        public LoginController(HealthcareDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("login/")]
        public IActionResult Login()
        {
            ViewBag.errorMessage = "";
            return View();
        }

        [HttpPost]
        [Route("login/")]
        public IActionResult Login(User user)
        {
            if(user.username==null || user.password == null)
            {
                ViewBag.errorMessage = "Invalid Input";
                return View();
            }
            else if(user.username.Length<3 || user.password.Length < 6)
            {
                ViewBag.errorMessage = "Invalid Input";
                return View();
            }
            else
            {
                User searchedUser = context.users.FirstOrDefault(u => u.username == user.username && u.password == user.password);
                if (searchedUser == null)
                {
                    ViewBag.errorMessage = "Invalid Input";
                    return View();
                }
                else
                {
                    if (searchedUser.username == "Admin")
                    {
                        ViewBag.errorMessage = "Admin Logged in successfully";
                        return View();
                    }
                    else
                    {
                        ViewBag.errorMessage = "Logged in successfully";
                        return View();
                    }
                }
            }
        }
    }
}

using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class RegisterController : Controller
    {
        private HealthcareDbContext context;

        public RegisterController(HealthcareDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("register/")]
        public IActionResult Index()
        {
            ViewBag.errorMessage = "";
            return View();
        }

        [HttpPost]
        [Route("register/")]
        public IActionResult Index(User user)
        {
            if (user == null || user.username == null || user.password == null || user.gender == null  || user.address==null || user.username.Length<3 || user.password.Length<5 || user.address.Length<6 || user.age<18 || user.age > 100)
            {
                ViewBag.errorMessage = "Invalid Input";
                return View();
            }
            else
            {
                context.users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Login", "Login");
            }
            
        }
    }
}

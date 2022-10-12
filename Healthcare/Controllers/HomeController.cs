using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class HomeController : Controller
    {
        private HealthcareDbContext context;
        public HomeController(HealthcareDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public List<User> GetUsers()
        {
            return context.users.ToList();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
            return Created("api/users/" + user.username, user);
        }


        public IActionResult Index()
        {
            return View();
        }

    }
}

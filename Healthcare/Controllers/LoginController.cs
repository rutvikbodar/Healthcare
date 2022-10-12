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


        public IActionResult Login()
        {
            return View();
        }
    }
}

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
            ViewBag.errorMessage = "form submitted";
            return View();
        }
    }
}

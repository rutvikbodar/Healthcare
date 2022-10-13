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

        public IActionResult Index()
        {
            return View();
        }
    }
}

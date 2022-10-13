using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class AdminHomeController : Controller
    {
        private HealthcareDbContext context;
        public AdminHomeController(HealthcareDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("adminhome")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

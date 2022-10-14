using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class UserDonateMedicineController : Controller
    {
        private HealthcareDbContext context;
        public UserDonateMedicineController(HealthcareDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/userDonateMedicine")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

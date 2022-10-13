using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class UserHomeController : Controller
    {
        private HealthcareDbContext context;
        public UserHomeController(HealthcareDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("userhome")]
        public IActionResult Index()
        {
            ViewBag.userRequests = context.requests.ToList();
            return View();
        }
    }
}

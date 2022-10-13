using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class AdminViewDonationsController : Controller
    {
        private HealthcareDbContext context;
        public AdminViewDonationsController(HealthcareDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("/adminViewDonations")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

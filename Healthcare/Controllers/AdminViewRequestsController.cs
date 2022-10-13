using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class AdminViewRequestsController : Controller
    {

        private HealthcareDbContext context;
        public AdminViewRequestsController(HealthcareDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("/adminViewRequests")]

        public IActionResult Index()
        {
            ViewBag.allRequests = context.requests.ToList();
            return View();
        }
    }
}

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
            List<Request> allRequests = context.requests.ToList();
            List<Request> userRequests = new List<Request>();
            foreach(Request req in allRequests)
            {
                if (req.requestorName == TempData.Peek("loggedInUsername").ToString())
                {
                    userRequests.Add(req);
                }
            }
            ViewBag.userRequests = userRequests;
            return View();
        }
    }
}

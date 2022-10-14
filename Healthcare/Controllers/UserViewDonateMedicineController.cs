using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class UserViewDonateMedicineController : Controller
    {
        private HealthcareDbContext context;
        public UserViewDonateMedicineController(HealthcareDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("/userViewDonateMedicine")]
        public IActionResult Index()
        {
            List<Donation> allDonations = context.donations.ToList<Donation>();
            List<Donation> userDonations = new List<Donation>();
            foreach(Donation don in allDonations)
            {
                if (don.donorName == TempData.Peek("loggedInUsername").ToString())
                {
                    userDonations.Add(don);
                }
            }
            ViewBag.userDonations = userDonations;
            return View();
        }
    }
}

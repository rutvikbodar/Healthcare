using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class UserRequestMedicineController : Controller
    {
        private HealthcareDbContext context;
        public UserRequestMedicineController(HealthcareDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("/userRequestMedicine")]
        public IActionResult Index()
        {
            ViewBag.errorMessage = "";
            ViewBag.medicineList = context.medicines.ToList();
            return View();
        }

        [HttpPost]
        [Route("/userRequestMedicine")]
        public IActionResult Index(Request req)
        {
            ViewBag.errorMessage = "Invalid Input";
            ViewBag.medicineList = context.medicines.ToList();
            return View();
        }
    }
}

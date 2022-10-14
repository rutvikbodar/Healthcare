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
            ViewBag.errorMessage = "";
            return View();
        }

        [HttpPost]
        [Route("/userDonateMedicine")]
        public IActionResult Index(Donation donation)
        {
            if(donation==null || donation.medicineCatagory==null || donation.medicineName==null || donation.medicineName.Length<4 || donation.medicineCatagory.Length < 4 || donation.donateQuantity < 1)
            {
                ViewBag.errorMessage = "Invalid Input";
                return View();
            }
            else
            {
                Medicine searchedMedicine = context.medicines.FirstOrDefault(med => med.name == donation.medicineName && med.category == donation.medicineCatagory);
                if (searchedMedicine == null)
                {
                    int id = context.medicines.ToList().Count + 1;
                    context.medicines.Add(new Medicine { id = id, category = donation.medicineCatagory,name = donation.medicineName,quantity = donation.donateQuantity });
                }
                else
                {
                    searchedMedicine.quantity += donation.donateQuantity;
                }
                donation.donorName = TempData.Peek("loggedInUsername").ToString();
                donation.pickupAddress = TempData.Peek("loggedInAddress").ToString();
                donation.donatedDate = DateTime.Now;
                context.donations.Add(donation);
                context.SaveChanges();

                return RedirectToAction("Index", "UserViewDonateMedicine");
            }
        }
    }
}

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
            if(req==null || req.medicineCatagory=="null" || req.medicineName=="null" || req.requestedQuantity < 1)
            {
                ViewBag.errorMessage = "Invalid Input";
                ViewBag.medicineList = context.medicines.ToList();
                return View();
            }
            else
            {
                Medicine searchedMed = context.medicines.FirstOrDefault(med => med.name == req.medicineName);
                if (searchedMed.quantity < req.requestedQuantity)
                {
                    ViewBag.errorMessage = "Invalid Input";
                    ViewBag.medicineList = context.medicines.ToList();
                    return View();
                }
                else
                {
                    searchedMed.quantity -= req.requestedQuantity;
                    int id = context.requests.ToList().Count + 1;
                    req.Id = id;
                    req.requestorName = TempData.Peek("loggedInUsername").ToString();
                    req.deliveredAddress = TempData.Peek("loggedInAddress").ToString();
                    req.requestedDate = DateTime.Today;
                    context.requests.Add(req);
                    context.SaveChanges();
                    return RedirectToAction("Index", "UserHome");
                }
            }
        }
    }
}

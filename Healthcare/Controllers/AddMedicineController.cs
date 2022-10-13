using Healthcare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    public class AddMedicineController : Controller
    {
        private HealthcareDbContext context;
        public AddMedicineController(HealthcareDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/addmedicine")]
        public IActionResult Index()
        {
            ViewBag.errorMessage = "";
            return View();
        }

        [HttpPost]
        [Route("/addmedicine")]
        public IActionResult Index(Medicine medicine)
        {
            if(medicine==null || medicine.category==null || medicine.name==null  || medicine.name.Length<4 || medicine.category.Length<4 || medicine.quantity<1 || medicine.quantity > 9999)
            {
                ViewBag.errorMessage = "Invalid Input";
                return View();
            }
            else
            {
                int id = context.medicines.ToList().Count + 1;
                medicine.id = id;
                Medicine searchedMedicine = context.medicines.FirstOrDefault(med => med.name == medicine.name);
                if (searchedMedicine == null)
                {
                    context.medicines.Add(medicine);
                }
                else
                {
                    searchedMedicine.quantity = searchedMedicine.quantity + medicine.quantity;
                }
                context.SaveChanges();
                System.Diagnostics.Debug.WriteLine(context.medicines.ToList().Count);
                return RedirectToAction("Index", "AdminHome");
            }
        }
    }
}

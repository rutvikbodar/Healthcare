using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string medicineCatagory { get; set; }
        public string medicineName { get; set; }
        public int donateQuantity { get; set; }
        public string donorName { get; set; }
        public string pickupAddress { get; set; }
        public DateTime donatedDate { get; set; }
    }
}

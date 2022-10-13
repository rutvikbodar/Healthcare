using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string medicineCatagory { get; set; }
        public string medicineName { get; set; }
        public int requestedQuantity { get; set; }
        public string requestorName { get; set; }
        public string deliveredAddress { get; set; }
        public DateTime requestedDate { get; set; }
    }
}

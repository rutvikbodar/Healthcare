using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Healthcare
{
    public class User
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
    }
}

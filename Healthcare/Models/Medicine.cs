﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Healthcare.Models
{
    public class Medicine
    {
        public int id { get; set; }
        [Key]
        public string name { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
    }
}

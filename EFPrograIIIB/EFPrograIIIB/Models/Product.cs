﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrograIIIB.Models
{
    public class Product
    {
        [Key]
        public int ProductIt { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } = null;
    }
}

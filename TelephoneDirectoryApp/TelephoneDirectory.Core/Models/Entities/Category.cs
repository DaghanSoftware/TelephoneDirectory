﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Models.Entities
{
    public class Category:BaseEntity
    {
        public int Name { get; set; }

        //Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
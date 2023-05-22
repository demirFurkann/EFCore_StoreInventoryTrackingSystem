﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category()
        {
            Product = new List<Product>();
        }
        //Relational Properties

        public virtual List<Product> Product { get; set; }
    }
}

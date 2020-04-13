﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.Models
{
   public class FruitAndVegetable
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}

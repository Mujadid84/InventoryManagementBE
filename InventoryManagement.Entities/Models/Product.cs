using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Entities.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

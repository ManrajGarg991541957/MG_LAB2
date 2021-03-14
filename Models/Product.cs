using System;
using System.Collections.Generic;

#nullable disable

namespace MG_LAB2
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

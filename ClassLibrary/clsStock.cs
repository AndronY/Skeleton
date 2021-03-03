using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockQuantity { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
    }
}
﻿namespace EMedicineBE.Models
{
    public class Medicines
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string Disease { get; set; }
        public string Uses { get; set; }
        public DateTime ExpDate { get; set; }
        public string ImageURL { get; set; }
        public int Status { get; set; }
        public string Type { get; set; }
    }
}

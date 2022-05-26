using System;

namespace BackendPlatypus.Models
{
    public class Ventas
    {
        public int Id { get; set; }

        public float TotalSale { get; set; }

        public DateTime Created_at { get; set; }
    }
}

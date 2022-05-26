namespace BackendPlatypus.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public float Price { get; set; }

        public float Amount { get; set; }

        public int IdProveedor { get; set; }

        public float Discount { get; set; }

        public float PriceWithDiscount { get; set; }
    }
}

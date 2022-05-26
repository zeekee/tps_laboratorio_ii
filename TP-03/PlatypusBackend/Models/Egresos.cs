using System;

namespace BackendPlatypus.Models
{
    public class Egresos
    {
        public int Id { get; set; }

        public float TotalCash { get; set; }

        public int IdProveedor { get; set; }

        public DateTime Created_at { get; set; }
    }
}

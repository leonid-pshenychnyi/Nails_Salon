using System;

namespace Nails_Salon.Models
{
    public class Purchase
    {
        public long Id { get; set; }
        public Guid UserId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int Qy { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Address { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; }

        public User User { get; set; }
        public ICollection<OrderItem> Items { get; set;}
        public ICollection<Payment> Payments { get; set;}
    }
}

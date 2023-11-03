using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public int PaymentMethod { get; set; }
        public int TransactionID { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public decimal PaymentAmount { get; set; }
        public string PaymentStatus { get; set; }

        public Order Order { get; set; }
    }
}

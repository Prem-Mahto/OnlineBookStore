using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }

    }
}

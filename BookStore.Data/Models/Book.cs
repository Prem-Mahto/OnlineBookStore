using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        //public List<string> Tags { get; set; }
        [ForeignKey("Genre")]
        public int GenreID { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string CoverImage { get; set; }

        public Genre Genre { get; set; }
        public ICollection<OrderItem> Items { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}

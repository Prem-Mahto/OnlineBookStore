namespace BookStore.Data.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

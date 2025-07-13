namespace Assignment3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string ShippingAddress { get; set; }
    }

    public class PurchaseHistory
    {
        public int id { get; set; }

        public int UserId { get; set; }

        public int OrderId { get; set; }
    }

}

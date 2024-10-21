namespace SeedData.Models
{
    internal class Orders
    {
        public int Id { get; set; }
        public decimal total { get; set; }
        public DateTime orderDate { get; set; }
        public int customerId { get; set; }
    }
}

namespace SeedData.Models
{
    internal class OredrItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal Quntitiy { get; set; }
    }
}

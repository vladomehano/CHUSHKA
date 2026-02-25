namespace kursovProekt.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public PTypes Ptype { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public enum PTypes
        {
            Food,
            Domestic,
            Health,
            Cosmetic,
            Other
        }
    }
}

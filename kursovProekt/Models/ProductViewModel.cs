using static kursovProekt.Data.Models.Product;

namespace kursovProekt.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public PTypes Ptype { get; set; }
        public enum PTypes
        {
            Food,
            Domestic,
            Health,
            Cosmetic,
            Other
        }
        public int ProductType { get; set; }
        public string[] ProductTypes = new[] { "Food", "Domestic", "Health", "Cosmetic", "Other" };
    }
}

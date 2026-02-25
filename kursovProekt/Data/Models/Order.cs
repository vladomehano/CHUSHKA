using System.Data;

namespace kursovProekt.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId   { get; set; }
        public User User { get; set; }
        public DataSetDateTime OrderOn { get; set; }
    }
}

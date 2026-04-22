using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace kursovProekt.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public DataSetDateTime OrderedOn { get; set; }
    }
}

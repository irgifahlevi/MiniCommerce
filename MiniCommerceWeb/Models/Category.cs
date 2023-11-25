using System.ComponentModel.DataAnnotations;
namespace MiniCommerceWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public int RowStatus { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {

        // columns we sant in category tables;
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}

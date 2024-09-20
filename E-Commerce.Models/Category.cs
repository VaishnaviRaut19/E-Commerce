using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]  // (Data Anotations) primary key
        public int Id { get; set; }
        [Required]
        [MaxLength(30)] // Server side validation
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "The field Display Order must be between 1-100.")] // Server side validation
        public int DisplayOrder { get; set; }
    }
}

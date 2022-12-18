using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Name cannot be {0} characters long")]
        [Display(Name = "Item Name")]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        [Required]
        [Display(Name = "Item Price")]
        public decimal Price { get; set; }
    }
}

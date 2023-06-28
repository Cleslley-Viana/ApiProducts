using System.ComponentModel.DataAnnotations;

namespace ApiProducts.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public float Value { get; set; }

        [Required]
        public int Quatity { get; set; }
    }
}

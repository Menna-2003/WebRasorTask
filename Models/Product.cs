using System.ComponentModel.DataAnnotations;

namespace WebRasorTask.Models {
    public class Product {
        [Key]
        public int id {
            get; set;
        }
        [Required]
        public string Name {
            get; set;
        }
        [Required]
        public double Price {
            get; set;
        }
        [Required]
        public int Quantity {
            get; set;
        }
    }
}

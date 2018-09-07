using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class Vehicals{
        [Required]
        [MinLength(3)]
        public string Make {get; set;}
        [Required]
        [MinLength(3)]
        public string Model {get; set;}
    }
}
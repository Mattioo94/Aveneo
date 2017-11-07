using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aveneo.Models
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 9)]
        [RegularExpression("(^[0-9]{9,10}$)|(^[A-Z]{2}[0-9]{10}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}$)|(^[0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{3}$)")]
        public string Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [Required]
        public int Nr { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6)]
        [RegularExpression("^[0-9]{2}-[0-9]{3}$")]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }
    }
}

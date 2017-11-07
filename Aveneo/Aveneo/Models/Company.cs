using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aveneo.Models
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10)]
        [RegularExpression(@"^((\d{3}-\d{3}-\d{2}-\d{2})|(\d{3}-\d{2}-\d{2}-\d{3})|([A-Z]{2}\d{10}))|(\d{9})|(\d{10})$")]
        [Display(Name = "NIP/REGON/KRS")]
        public string Number { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Nr")]
        public int Nr { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 6)]
        [RegularExpression(@"^\d{2}-\d{3}$")]
        [Display(Name = "Kod pocztowy")]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Miasto")]
        public string City { get; set; }
    }
}

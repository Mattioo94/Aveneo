using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aveneo.Models
{
    [Table("Requests")]
    public class Request
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10)]
        [RegularExpression(@"^((\d{3}-\d{3}-\d{2}-\d{2})|(\d{3}-\d{2}-\d{2}-\d{3})|([A-Z]{2}\d{10}))|(\d{9})|(\d{10})$")]
        public string Number { get; set; }

        [Required]
        [JsonProperty]
        public string Headers { get; set; }
    }
}

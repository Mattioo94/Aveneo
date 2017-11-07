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
        [StringLength(13, MinimumLength = 9)]
        [RegularExpression("(^[0-9]{9,10}$)|(^[A-Z]{2}[0-9]{10}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}$)|(^[0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{3}$)")]
        public string Number { get; set; }

        [Required]
        [JsonProperty]
        public string Headers { get; set; }
    }
}

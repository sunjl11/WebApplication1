using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class student
    {
        public int Id { get; set; }
        public string? Nameuse { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Brith { get; set; }
        public string? phon { get; set; }
        public float? Tem { get; set; }
        public DateTime? Datetime { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApi.Models
{
    public class Commentary
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        public User User { get; set; }
    }
}

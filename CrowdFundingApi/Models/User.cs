using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Pseudo { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        [Required]
        public string Pwd { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

        public List<Project> UserProject { get; set; }

    }
}

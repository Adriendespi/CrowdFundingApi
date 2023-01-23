using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApi.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MinLength(100)]
        public string Description { get; set; }
        public string? img { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int SumGoal { get; set; }
        public int Sum { get; set; }
        [Required]
        public User ProjectManager { get; set; }

        public List<User> Donator { get; set; }


    }
}

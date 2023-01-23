using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrowdFundingDAL.Models
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
       
        public ICollection<UserProjectMTM> UsersProjects { get; set; } = new List<UserProjectMTM>();

    }
}

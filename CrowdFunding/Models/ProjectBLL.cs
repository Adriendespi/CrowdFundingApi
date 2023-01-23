using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Models
{
    public class ProjectBLL
    {
        
        public int Id { get; set; }
     
        public string Name { get; set; }
     
        public string Description { get; set; }
        public string? img { get; set; }
      
        public DateTime StartDate { get; set; }
    
        public DateTime EndDate { get; set; }
     
        public int SumGoal { get; set; }
        public int Sum { get; set; }
      
        public UserBLL ProjectManager { get; set; }

        public  ICollection<UserProjectMTM> Donator { get; set; } = new List<UserProjectMTM>();
    }
}

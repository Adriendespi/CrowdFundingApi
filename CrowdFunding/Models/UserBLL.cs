using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Models
{
    public class UserBLL
    {
      
        public int Id { get; set; }
       
        public string Pseudo { get; set; }
       
        public string Mail { get; set; }
        
        public string Pwd { get; set; }
        
        public bool IsAdmin { get; set; }


        public ICollection<UserProjectMTM> UsersProjects { get; set; } = new List<UserProjectMTM>();
    }
}

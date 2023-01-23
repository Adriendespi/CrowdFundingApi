using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Models
{
    public class UserProjectMTM
    {
        public int PId { get; set; }
        public Project Project { get; set; }

        public int UId { get; set; }
        public User User { get; set; }
    }
}

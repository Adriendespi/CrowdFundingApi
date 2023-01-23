using CrowdFundingBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Tools.DTO.ProjectDTO
{
    public class ProjectCreate
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string? img { get; set; }

        public DateTime EndDate { get; set; }

        public int SumGoal { get; set; }

        public int ProjectManagerId { get; set; }
    }
}

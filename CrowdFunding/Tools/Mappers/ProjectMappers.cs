using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using CrowdFundingDAL.Interfaces;
using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Tools.Mappers
{
    public static  class ProjectMappers
    {
        
        public static ProjectBLL ToEntity (this ProjectCreate project)
        {
           

            return new ProjectBLL
            {

                Name = project.Name,
                Description = project.Description,
                EndDate = project.EndDate,
                SumGoal = project.SumGoal,
                img = project.img,
                StartDate=DateTime.Now,
                
              
                
            };
        }
        public static Project ToDal(this ProjectBLL project)
        {
            return new Project
            {
                Name = project.Name,
                Description = project.Description,
                EndDate = project.EndDate,
                SumGoal = project.SumGoal,
                img = project.img,
                Sum = project.Sum,
                StartDate = project.StartDate,
            };
        }
        public static ProjectBLL ToBll(this Project project) 
        {
            return new ProjectBLL
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                EndDate = project.EndDate,
                SumGoal = project.SumGoal,
                ProjectManager = project.ProjectManager.ToBLL(),
                Sum = project.Sum,
                StartDate = project.StartDate,
                img= project.img,


            };
        }
    }
}

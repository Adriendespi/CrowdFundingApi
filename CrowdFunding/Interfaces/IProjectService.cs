using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Interfaces
{
    public interface IProjectService
    {
        void CreateProject(ProjectCreate projectCreate);

        bool UpdateProject(ProjectBLL newProject);

        bool DeleteProject(int id);

        ProjectBLL GetProject(int id);
        
        IEnumerable<ProjectBLL> GetAllProjects();
    }
}

using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using CrowdFundingBLL.Tools.Mappers;
using CrowdFundingDAL.Interfaces;
using CrowdFundingDAL.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Services
{
    public class ProjectService : IProjectService
    {
        IProjectRepository _repo;
        IUserRepository _userRepository;
        public ProjectService(IProjectRepository repo, IUserRepository userRepository)
        {
            _repo = repo;
            _userRepository = userRepository;
        }

        public void CreateProject(ProjectCreate projectCreate)
        {
            if (projectCreate == null || _repo.CheckExiste(projectCreate.Name)) 
            throw new Exception("Projet deja existant ou donné erroner");




            Project project = (projectCreate.ToEntity().ToDal());   
            project.ProjectManager= _userRepository.GetById( projectCreate.ProjectManagerId);
            
            _repo.Insert(project);
        }

        public bool DeleteProject(int id)
        {
            try
            {
                _repo.Delete(_repo.GetById(id));
                return true;
            } 
            catch 
            {
               return false;
            }
        }

        public IEnumerable<ProjectBLL> GetAllProjects()
        {
            return _repo.GetAll().Select(x=> x.ToBll());
        }

        public ProjectBLL GetProject(int id)
        {
            try
            {
                return _repo.GetById(id).ToBll();
            }
            catch
            {
                throw new Exception("Projet introuvable");
            }
        }

        public bool UpdateProject(int id,ProjectCreate newProject)
        {
         
            ProjectBLL project= newProject.ToEntity();
            project.Id=id;
            return _repo.Update(project.ToDal());
        
        }
    }
}

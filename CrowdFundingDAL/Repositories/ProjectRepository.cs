using CrowdFundingDAL.GestionEntity.context;
using CrowdFundingDAL.Interfaces;
using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Repositories
{
    public class ProjectRepository:BaseRepository<Project>,IProjectRepository
    {
        public DataContext _Context;

        public ProjectRepository(DataContext context):base(context)
        {
            _Context=context;
        }
        public bool CheckExiste(string name)
        {
            //verifie si les donner existe
            return (_Context.projects.Any(m => m.Name == name ));

        }
        public override Project Insert(Project project)
        {
            
            _Context.Add(project);
            _Context.SaveChanges();
            return (project);
        }
        public ICollection<Project> GetProjectList(int id)
        {
             return _Context.projects.Where(u => u.ProjectManager.Id == id).ToList();
        }
    }
}

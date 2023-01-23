using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Interfaces
{
    public interface IProjectRepository:IRepository<Project>
    {
        bool CheckExiste(string name);
    }
}

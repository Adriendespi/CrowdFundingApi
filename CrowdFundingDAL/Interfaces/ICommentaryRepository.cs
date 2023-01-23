using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Interfaces
{
    public interface ICommentaryRepository:IRepository<Commentary>
    {
        IEnumerable<Commentary> GetAllCommentFromProject(int projectid);
    }
}

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
    public class CommentaryRepository:BaseRepository<Commentary>,ICommentaryRepository
    {
        public DataContext _Context;

        public CommentaryRepository(DataContext context):base(context)
        {
        }

        public IEnumerable<Commentary> GetAllCommentFromProject(int projectid)
        {
            return _Context.comments.Where(x => x.Project.Id == projectid);
           
        }
    }
}

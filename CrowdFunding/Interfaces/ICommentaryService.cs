using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.CommentaryDTO;
using CrowdFundingBLL.Tools.DTO.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Interfaces
{
    public interface ICommentaryService
    {
        void CreateCommentary(CommentaryCreate comment);

        bool UpdateCommentary(CommentaryBLL comment);

        bool DeleteCommentary(int id);

        CommentaryBLL GetCommentary(int id);

        IEnumerable<CommentaryBLL> GetAllCommentFromProjects(int projectid);
    }
}

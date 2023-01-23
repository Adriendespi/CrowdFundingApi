using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.CommentaryDTO;
using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Tools.Mappers
{
    public static class CommentaryMappers
    {
        public static Commentary  ToDal (this CommentaryBLL commentary)
        {
            return new Commentary
            {
                
                Text= commentary.Text,
                Project = commentary.Project.ToDal(),
                User = commentary.User.ToDAL(),

            };
        }
        public static CommentaryBLL ToBll(this Commentary commentary)
        {
            return new CommentaryBLL
            {
                ID = commentary.Id,
                Text = commentary.Text,
                Project = commentary.Project.ToBll(),
                User = commentary.User.ToBLL(),

            };
        }
        public static CommentaryBLL ToEntity(this CommentaryCreate commentary)
        {
            return new CommentaryBLL
            {
                
            };
        }
    }
}

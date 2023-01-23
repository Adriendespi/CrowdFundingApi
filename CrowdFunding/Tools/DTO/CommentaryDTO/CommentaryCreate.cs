using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Tools.DTO.CommentaryDTO
{
    public class CommentaryCreate
    {
        public string Text { get; set; }
        public int UserID { get; set; }
        public int ProjectId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Models
{
    public class CommentaryBLL
    {
        public int ID { get; set; }
        public string Text { get; set; }
        
        public UserBLL User { get; set; }
        public ProjectBLL Project { get; set; }
    }
}

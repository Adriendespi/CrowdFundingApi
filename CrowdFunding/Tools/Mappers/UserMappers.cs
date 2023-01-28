using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.UserDTO;
using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Tools.Mappers
{
    public static class UserMappers
    {
        public static UserBLL ToEntity(this UserRegister user)
        {
            return new UserBLL
            {
                Pseudo = user.Pseudo,
                Pwd = user.Pwd,
                Mail = user.Mail,
              
                
                
            };
        }
        public static User ToDAL(this UserBLL user)
        {
            return new User
            {
                Id = user.Id,
                Pseudo = user.Pseudo,
                Mail = user.Mail,
                Pwd = user.Pwd,
                IsAdmin = user.IsAdmin,
                UsersProjects = user.UsersProjects,

            };
        }
        public static UserBLL ToBLL(this User user)
        {
            return new UserBLL
            {
                Id = user.Id,
                Pseudo = user.Pseudo,
                Mail = user.Mail,
                Pwd = user.Pwd,
                IsAdmin = user.IsAdmin,
                UsersProjects = user.UsersProjects

                

            };
        }
    }
}

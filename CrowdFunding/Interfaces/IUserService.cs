using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.UserDTO;
using CrowdFundingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Interfaces
{
    public interface IUserService
    {
        User Login(UserLogin userLogin);

        User Register(UserRegister userRegister);

        bool Update(int id,UserRegister newUser);
        // - Delete
        bool Delete(int id);

        UserBLL GetUser(int id);

        IEnumerable<UserBLL> GetAllUsers();
    }
}

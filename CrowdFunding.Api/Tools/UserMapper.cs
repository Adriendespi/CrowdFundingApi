using CrowdFunding.Api.Model;
using CrowdFundingBLL.Models;

namespace CrowdFunding.Api.Tools
{
    public static  class UserMapper
    {
        public static UserApi ToApi(this UserBLL User)
        {
            return new UserApi
            {
                Id = User.Id,
                Pseudo = User.Pseudo,
                IsAdmin = User.IsAdmin
            };
        }
    }
}

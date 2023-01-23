using CrowdFundingDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
         User? GetByUsername(string username);

        string? GetHashByName(string pseudo);

        bool CheckExiste(string pseudo, string mail);



    }
}

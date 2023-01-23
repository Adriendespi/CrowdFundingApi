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
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public DataContext _Context;

        public UserRepository(DataContext context) : base(context) 
        { }

        public User? GetByUsername(string username)
        {
            //renvoie un obj user sur base du pseudo ou du mail
            return _Context.users.FirstOrDefault(m => m.Pseudo == username || m.Mail == username);
        }
        public string? GetHashByName(string username)
        {
            //recupere le mdp qui va avec le username
            return _Context.users.Where(m => m.Pseudo == username || m.Mail == username)
                .Select(m => m.Pwd)
                .SingleOrDefault();
        }
        public bool CheckExiste(string pseudo, string mail)
        {
            //verifie si les donner existe
            return !(_Context.users.Any(m => m.Pseudo == pseudo || m.Mail == mail));

        }

    }
}

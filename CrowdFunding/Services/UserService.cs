using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.UserDTO;
using CrowdFundingBLL.Tools.Mappers;
using CrowdFundingDAL.Interfaces;
using CrowdFundingDAL.Models;
using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Services
{
    public class UserService : IUserService  
    {
        IUserRepository _Repo;
        public UserService(IUserRepository r)
        {
            _Repo=r;
        }
        public User Login(UserLogin userLogin)
        {
            string hash = _Repo.GetHashByName(userLogin.Pseudo);

            if (string.IsNullOrWhiteSpace(hash))
            {
                throw new Exception("Pseudo ou mail incorect");
            }

           
            if (Argon2.Verify(hash, userLogin.Pwd))
            {
                return _Repo.GetByUsername(userLogin.Pseudo);
            }
            else
            {
                throw new Exception("User ou mot de passe éronné");
            }
        }

        public User Register(UserRegister userRegister)
        {
            if (!_Repo.CheckExiste(userRegister.Pseudo, userRegister.Mail))
                throw new Exception("Pseudo ou Email déjà utilisé");

            userRegister.Pwd=Argon2.Hash(userRegister.Pwd);
            User user = userRegister.ToEntity().ToDAL(); 

            _Repo.Insert(user);
            return user;

        }
        public UserBLL GetUser(int id)
        {
            try
            {
                return _Repo.GetById(id).ToBLL();
            }
            catch
            {
                throw new Exception("Utilisateur introuvable");
            }
            
        }
        public IEnumerable<UserBLL> GetAllUsers() 
        {
            try
            {
                return _Repo.GetAll().Select(x => x.ToBLL());
            }
            catch
            {
                throw new Exception ("impossible de chatger les utilisateur");
            }
            
        }
        public bool Delete(int id)
        {
           return _Repo.Delete(_Repo.GetById(id));
            
        }
        public bool Update(int id,UserRegister newUser)
        {
            UserBLL user= newUser.ToEntity();
            user.Id= id;
            return _Repo.Update(user.ToDAL());

        }


    }
}

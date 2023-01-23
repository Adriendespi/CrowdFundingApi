using CrowdFundingBLL.Interfaces;
using CrowdFundingBLL.Models;
using CrowdFundingBLL.Tools.DTO.CommentaryDTO;
using CrowdFundingBLL.Tools.Mappers;
using CrowdFundingDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingBLL.Services
{
    public class CommentaryService : ICommentaryService
    {
        ICommentaryRepository _commentRepo;
        IUserRepository _userRepository;
        IProjectRepository _projectRepository;
        public CommentaryService(ICommentaryRepository commentRepo, IUserRepository userRepository, IProjectRepository projectRepository)
        {
            _commentRepo = commentRepo;
            _userRepository = userRepository;
            _projectRepository = projectRepository;
        }

        public void CreateCommentary(CommentaryCreate newcomment)
        {
            try
            {
                CommentaryBLL comment = new CommentaryBLL();
                comment.Text = newcomment.Text;
                comment.Project = _projectRepository.GetById(newcomment.ProjectId).ToBll();
                comment.User = _userRepository.GetById(newcomment.UserID).ToBLL();
                _commentRepo.Insert(comment.ToDal());
            }
            catch
            {
                throw new Exception("Le Commentaire n'a pas pu etre créer");
            }
            

        }

        public bool DeleteCommentary(int id)
        {
            return _commentRepo.Delete(_commentRepo.GetById(id));
        }

        public IEnumerable<CommentaryBLL> GetAllCommentFromProjects(int projectid)
        {
            try
            {
                return _commentRepo.GetAllCommentFromProject(projectid).Select(w=> w.ToBll());
            }
            catch
            {
                throw new Exception("Commentaires introuvable");
            }
        }

        public CommentaryBLL GetCommentary(int id)
        {
            try
            {
                return _commentRepo.GetById(id).ToBll();
            }
            catch
            {
                throw new Exception("La recuperation des commentaire à echouer");
            }
        }

        public bool UpdateCommentary(CommentaryBLL comment)
        {
            return _commentRepo.Update(comment.ToDal());
        }
    }
}

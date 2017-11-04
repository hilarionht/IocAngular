using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core.Data;
using Ioc_AngularSPA.Repo;

namespace Ioc_AngularSPA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<UserProfile> _userProfileRepository;

        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this._userRepository = userRepository;
            this._userProfileRepository = userProfileRepository;
        }

        public UserService()
        {
            
        }

        public IQueryable<User> GetUsers()
        {
            return _userRepository.GetAll().AsQueryable<User>();
        }

        public User GetUser(long id)
        {
            return _userRepository.GetById(id);
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            //userRepository.u(user);
        }

        public void DeleteUser(User user)
        {
            _userProfileRepository.Delete(user.UserProfile);
            _userRepository.Delete(user);
        }
        //public IEnumerable<User> GetAll()
        //{
        //    return userRepository.Table.ToList;
        //}
    }
}

using Praksa.DB;
using Praksa.Domain;
using Praksa.Models;
using System.Collections.Generic;
using System.Linq;

namespace Praksa.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static DbContext _dbContext = new DbContext();
        public UserRepository()
        {
            _dbContext.Users = new List<User>();
            Add(new User() { UserName = "Admir", Email = "test@gmail.com", Password = "test123" });
            // Seed data
        }

        public User Add(User user)
        {
            _dbContext.Users.Add(user);
            return user;
        }

        public List<User> GetAll()
        {
            return _dbContext.Users;
        }

        public User GetbyId(int userId)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserId == userId);
        }

        public UserViewModel LogIn(string username, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Email == username && x.Password == password);
            if (user != null)
            {
                return new UserViewModel()
                {
                    Email = user.Email,
                    Name = user.UserName,
                    UserId = user.UserId
                };
            }
            return new UserViewModel();
        }
    }
}

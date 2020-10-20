using Praksa.Domain;
using System.Collections.Generic;

namespace Praksa.Repositories
{
    public interface IUserRepository
    {
        User GetbyId(int userId);
        List<User> GetAll();
        User Add(User user);
    }
}

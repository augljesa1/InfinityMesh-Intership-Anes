using Praksa.Domain;
using System.Collections.Generic;

namespace Praksa.DB
{
    public class DbContext
    {
        public List<User> Users { get; set; }
        public List<Account> Accounts { get; set; }
    }
}

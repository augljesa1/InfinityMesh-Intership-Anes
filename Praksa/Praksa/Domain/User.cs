using System.Collections.Generic;

namespace Praksa.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}

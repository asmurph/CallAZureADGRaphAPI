using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallAZureADGRaphAPI.Models
{
    public class User
    {
        public string Id { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string UserPrincipalName { get; set; }
        public string Email { get; set; }
    }

    public class Users
    {
        public int ItemsPerPage { get; set; }
        public int StartIndex { get; set; }
        public int TotalResults { get; set; }
        public List<User> Resources { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallAZureADGRaphAPI.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
    }

    public class Groups
    {
        public int ItemsPerPage { get; set; }
        public int StartIndex { get; set; }
        public int TotalResults { get; set; }
        public List<Group> Resources { get; set; }
    }
}

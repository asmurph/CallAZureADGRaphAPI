using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallAZureADGRaphAPI.Controllers;
using CallAZureADGRaphAPI.Models;

namespace CallAZureADGRaphAPI.Services
{
    public class CopyHandler
    {
        public static User UserProperty(Microsoft.Graph.User graphUser)
        {
            User user = new User();
            user.Id = graphUser.Id;
            user.GivenName = graphUser.GivenName;
            user.Surname = graphUser.Surname;
            user.UserPrincipalName = graphUser.UserPrincipalName;
            user.Email = graphUser.Mail;

            return user;
        }

        public static Group GroupProperty(Microsoft.Graph.Group graphGroup)
        {
            Group group = new Group();
            group.Id = graphGroup.Id;
            group.DisplayName = graphGroup.DisplayName;

            return group;
        }
    }
}

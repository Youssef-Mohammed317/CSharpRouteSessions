using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Q2
{
    [Flags]
    enum Roles
    {
        None = 0,
        Trainee = 1,
        Employee = 2,
    }

    internal class BasicAuthenticationService : IAuthenticationService
    {
        Dictionary<string, string> credentials;
        Dictionary<string, Roles> userRoles;

        public BasicAuthenticationService()
        {
            credentials = new Dictionary<string, string>();
            userRoles = new Dictionary<string, Roles>();
        }
        public bool AuthenticateUser(string username,string password)
        {
            if(credentials.ContainsKey(username))
            {
                return credentials[username] == password;
            }

            return false;
        }

        public bool AuthorizeUser(string username, Roles role)
        {
            if (userRoles.ContainsKey(username))
            {
                Roles roles1 = userRoles[username];

                roles1 &= role;

                return roles1 == role;
            }

            return false;
        }
    }
}

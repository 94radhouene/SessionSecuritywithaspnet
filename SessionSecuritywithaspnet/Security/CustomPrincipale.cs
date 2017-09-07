using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using SessionSecuritywithaspnet.Models;

namespace SessionSecuritywithaspnet.Security
{
    public class CustomPrincipal : IPrincipal
    {
        Account account;
      
        public CustomPrincipal(Account account)
        {
            this.account = account; 
            this.Identity = new GenericIdentity(account.username);

        }
        public IIdentity Identity
        {
            get;
            set;
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.account.Roles.Contains(r));
        }
    }
}
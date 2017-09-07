using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionSecuritywithaspnet.Models
{
    public class AccountModel
    {
        //Nouvel List Account
        private List<Account> listAccounts = new List<Account>();
        //Creation de nouvel Account
        public AccountModel() 
            {
            listAccounts.Add(new Account { username = "Radhouene", Password = "123", Roles = new string[] { "superadmin", "admin", "employee" } });
            listAccounts.Add(new Account { username = "Mohamed", Password = "456", Roles = new string[] {  "admin", "employee" } });
            listAccounts.Add(new Account { username = "Aymen", Password = "789", Roles = new string[] {  "employee" } });
        }
        //Find Account by username
        public Account find(string username)
        {
            return listAccounts.Where(acc => acc.username.Equals(username)).FirstOrDefault();
        }
        //Login and pass 
        public Account login(string username , string password)
        {
            return listAccounts.Where(acc => acc.username.Equals(username) && acc.Password.Equals(password)).FirstOrDefault();
        }
    }
}
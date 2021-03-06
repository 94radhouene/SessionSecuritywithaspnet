﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionSecuritywithaspnet.Security
{
    public static class SessionPersister
    {
        static string usernameSessionvar = "username";
        public static string username
        {
            get {
                if (HttpContext.Current == null)
                    return (string.Empty);
                var sessionvar = HttpContext.Current.Session[usernameSessionvar];
                if (sessionvar != null)
                    return sessionvar as string;
                return null;

            }
            set
            {
                HttpContext.Current.Session[usernameSessionvar] = value;
            }
        }

    }
}
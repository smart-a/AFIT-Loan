using AFIT_Cooperative.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace WisejWebApplication1.Middleware
{
    public class Auth
    {
        public static object ValidateUser()
        {
            object user = null;
            Application.Browser.LocalStorage.GetValue("afit", (string token) =>
            {
                if (token == null)
                {
                    MessageBox.Show("Unathorized user");
                    Application.Navigate("/");
                    return;
                }

                user = JwtToken.DecodeToken(token);
                if (user == null)
                {
                    MessageBox.Show("Invalid user");
                    Application.Navigate("/");
                    return;
                }
            });
            return user;
        }
    }
}
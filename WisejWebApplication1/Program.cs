using System;
using Wisej.Web;
using System.Collections.Generic;
using System.Collections.Specialized;
using AFIT_Cooperative.Registration;
using System.Web;
using System.Web.Routing;
using AFIT_Cooperative.Helper;
using AFIT_Cooperative.Models;
using AFIT_Cooperative.Dashboard;
using AFIT_Cooperative.Admin;
using AFIT_Cooperative.Admin.Dashboard;

namespace AFIT_Cooperative
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.Browser.LocalStorage.GetValue("AFIT_user", (string token) =>
            {
                if (token != null)
                {
                    var member = Auth.ValidateUser(JwtToken.DecodeToken(token));
                    if (member != null)
                    {
                        Application.Navigate("/Dashboard");
                        return;
                    }
                }
                LandingPage window = new LandingPage();
                window.Show();
            });
            
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

        static void Registration()
        {
            WinRegistration win = new WinRegistration();
            win.Show();
        }

        static void Dashboard()
        {
            Application.Browser.LocalStorage.GetValue("AFIT_user", (string token) =>
            {
                if (token != null)
                {
                    var member = Auth.ValidateUser(JwtToken.DecodeToken(token));
                    if (member != null)
                    {
                        UserDashboard win = new UserDashboard(member);
                        win.Show();
                        return;
                    }
                }
                Application.Navigate("/");
            });
        }

        static void Admin()
        {
            Application.Browser.LocalStorage.GetValue("AFIT_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        Application.Navigate("/Admin/Dashboard");
                        return;
                    }
                }
            });
            AdminLogin window = new AdminLogin();
            window.Show();
        }

        static void AdminDashboard()
        {
            Application.Browser.LocalStorage.GetValue("AFIT_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        AdminDashboard window = new AdminDashboard();
                        window.Show();
                        return;
                    }
                }
                Application.Navigate("/Admin");
            });
        }
    }
}
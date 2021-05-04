using System;
using Wisej.Web;
using System.Collections.Generic;
using System.Collections.Specialized;
using AFIT_Cooperative.Registration;
using System.Web;
using System.Web.Routing;
using AFIT_Cooperative.Helper;
using AFIT_Cooperative.Models;
using WisejWebApplication1.Dashboard;

namespace AFIT_Cooperative
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            window1 window = new window1();
            window.Show();
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
            Application.Browser.LocalStorage.GetValue("afit", (string token) =>
            {
                if (token == null)
                {
                    MessageBox.Show("Unathorized user");
                    Application.Navigate("/");
                    return;
                }

                var member = JwtToken.DecodeToken(token);
                if (member == null)
                {
                    MessageBox.Show("Invalid user");
                    Application.Navigate("/");
                    return;
                }

                Dashboard win = new Dashboard(member);
                win.Show();
            });
        }
    }
}
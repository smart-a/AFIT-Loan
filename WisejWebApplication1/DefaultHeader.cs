using System;
using Wisej.Web;

namespace AFIT_Cooperative
{
    public partial class DefaultHeader : Wisej.Web.UserControl
    {
        public DefaultHeader()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Navigate("/");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(btnSignUp.Tag.ToString() == "signup")
            {
                Application.Navigate("/Registration");
            }
            else if(btnSignUp.Tag.ToString() == "login")
            {
                Application.Navigate("/");
            }
        }
    }
}

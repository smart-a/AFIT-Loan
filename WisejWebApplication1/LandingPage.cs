
using System;
using Wisej.Web;
using Wisej.Core;
using System.Linq;
using AFIT_Cooperative.Registration;
using AFIT_Cooperative.Data;
using AFIT_Cooperative.Helper;
using AFIT_Cooperative.Models;
using System.Text;

namespace AFIT_Cooperative
{
    public partial class LandingPage : Form
    {
        ApplicationDbContext _context;

        public LandingPage()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            defaultHeader1.btnSignUp.Text = "Sign Up";
            defaultHeader1.btnSignUp.Tag = "signup";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                HandleLogin();
            }
        }

        private void HandleLogin()
        {
            try
            {
                string pass = EncryptPass(txtPassword.Text);
                var member = _context.Members.SingleOrDefault(
                    (m) => m.Email == txtEmail.Text || m.StaffNumber == txtEmail.Text);

                if (member != null)
                {
                    if (member.Password == pass)
                    {
                        DisplayMsg("Login successful, redirecting to dashboard...", false);
                        JwtToken.GenerateToken(member, (token) =>
                        {
                            Application.Browser.LocalStorage.SetValue("AFIT_user", token);
                            Application.Navigate("/Dashboard");
                        });
                    }
                    return;
                }
                DisplayMsg("Account not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayMsg(string message, bool displayCloseButton = true)
        {
            msgPanel.Visible = true;
            lblMsg.Text = message;
            btnMsgClose.Visible = displayCloseButton;
        }

        private void btnMsgClose_Click(object sender, EventArgs e)
        {
            msgPanel.Visible = false;
        }

        private string EncryptPass(string Password)
        {
            byte[] encode = new byte[Password.Length];
            encode = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(encode);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
        }
    }
}

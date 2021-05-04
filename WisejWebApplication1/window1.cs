
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
    public partial class window1 : Form
    {
        readonly ApplicationDbContext _context;
        public window1()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            defaultHeader1.btnSignUp.Text = "Sign Up";
            defaultHeader1.btnSignUp.Tag = "signup";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string pass = EncryptPass(txtPassword.Text);
            var member = _context.Members.SingleOrDefault(
                (m) => m.Email == txtEmail.Text && m.Password == pass);

            if (member != null)
            {
                try
                {
                    var token = JwtToken.GenerateToken(member);
                    Application.Browser.LocalStorage.SetValue("afit", token);
                    Application.Navigate("/Dashboard");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DisplayMsg("Account not found");
            }
        }

        private void DisplayMsg(string message)
        {
            msgPanel.Visible = true;
            lblMsg.Text = message;
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
    }
}

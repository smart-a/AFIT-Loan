using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace AFIT_Cooperative
{
    public partial class ForgetPassword : Form
    {
        ApplicationDbContext _context;
        Member member;

        public ForgetPassword()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            this.Height = 230;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Focus();
                return;
            }
            if (txtStaffNumber.Text == "")
            {
                txtStaffNumber.Focus();
                return;
            }

            try
            {
                member = _context.Members.SingleOrDefault((m) => m.Email == txtEmail.Text.ToLower() &&
                    m.StaffNumber == txtStaffNumber.Text.ToLower());

                if (member == null)
                {
                    MessageBox.Show("Account not found!!!");
                    return;
                }
                panelUserInfo.Enabled = false;
                this.Height = 490;
            }
            catch
            {
                MessageBox.Show("Some errors occur");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password not matched");
                txtCPassword.Focus();
                return;
            }
            try
            {
                member.Password = EncryptPass(txtPassword.Text);
                _context.Entry(member).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Your password has been reset");
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Some errors occur");
            }
        }

        private string EncryptPass(string Password)
        {
            byte[] encode = new byte[Password.Length];
            encode = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(encode);
        }
    }
}

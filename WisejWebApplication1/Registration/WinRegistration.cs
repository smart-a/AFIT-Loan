using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Wisej.Web;

namespace AFIT_Cooperative.Registration
{
    public partial class WinRegistration : Form
    {
        ApplicationDbContext _context;
        Member _member;
        public WinRegistration()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            defaultHeader1.btnSignUp.Tag = "login";
            defaultHeader1.btnSignUp.Text = "Login";
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                _member = new Member()
                {
                    StaffNumber = txtStaffNumber.Text,
                    Fullname = txtFullname.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Gender = radioMale.Checked ? "Male" : "Female",
                    Password = EncryptPass(txtPassword.Text)
                };

                if (!IsValidInput())
                {
                    MessageBox.Show("Some fields are empty");
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password not matched");
                    txtConfirmPassword.Focus();
                    return;
                }
                if (MemberExists(_member))
                {
                    MessageBox.Show("Member already exist, check Staff Number or Email");
                    txtStaffNumber.Focus();
                    return;
                }

                _context.Members.Add(_member);
                await _context.SaveChangesAsync();
                MessageBox.Show("Registration successful\nClick OK to login to your account");
                Application.Navigate("/");
            }
            catch
            {
                MessageBox.Show("Some error occur");
            }
        }

        private bool IsValidInput()
        {
            PropertyInfo[] properties = _member.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //if(property
                var prop = property.Name;
                if (prop != "Item")
                {
                    if (_member[prop].ToString() == "")
                    {
                        var c = this.Controls.Find($"txt{prop}", true)[0];
                        c.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private bool MemberExists(Member member)
        {
            return _context.Members.Any(
                e => e.StaffNumber == member.StaffNumber && e.Email == member.Email);
        }

        private string EncryptPass(string Password)
        {
            byte[] encode = new byte[Password.Length];
            encode = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(encode);
        }
    }
}

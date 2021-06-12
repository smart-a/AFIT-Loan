using AFIT_Cooperative.Models;
using System;
using Wisej.Web;

namespace AFIT_Cooperative.Dashboard
{
    public partial class UserDashboard : Form
    {
        Member _member;
        public UserDashboard(Member member)
        {
            InitializeComponent();
            _member = member;
        }

        private void btnNavShow_Click(object sender, EventArgs e)
        {
            if (btnNavShow.Tag.ToString() == "show")
            {
                btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times.svg";
                btnNavShow.Tag = "hide";
                navigationBar1.CompactView = false;
            }
            else if (btnNavShow.Tag.ToString() == "hide")
            {
                btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
                btnNavShow.Tag = "show";
                navigationBar1.CompactView = true;
            }
        }

        public void NavigateMenu(Control control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
            btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
            btnNavShow.Tag = "show";
            navigationBar1.CompactView = true;
        }

        private void navDashboard_Click(object sender, EventArgs e)
        {
            Index control = new Index(_member);
            NavigateMenu(control);
        }

        private void navMySaving_Click(object sender, EventArgs e)
        {
            MySavings control = new MySavings(_member);
            NavigateMenu(control);
        }

        private void navMyLoan_Click(object sender, EventArgs e)
        {
            MyLoan control = new MyLoan(_member);
            NavigateMenu(control);
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            Index control = new Index(_member);
            NavigateMenu(control);

            btnUser.MenuItems[0].Text = _member.Fullname;
        }

        private void btnUser_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            if(e.Item.Name == "menuLogout")
            {
                Application.Browser.LocalStorage.RemoveValue("AFIT_user");
                Application.Navigate("/");
            }
        }
    }
}

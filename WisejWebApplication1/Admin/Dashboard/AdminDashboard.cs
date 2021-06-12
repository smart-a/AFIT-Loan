using System;
using System.IO;
using Wisej.Web;

namespace AFIT_Cooperative.Admin.Dashboard
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
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

        private void btnUser_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            if (e.Item.Name == "menuLogout")
            {
                Application.Browser.LocalStorage.RemoveValue("e_library_admin");
                Application.Navigate("/Admin");
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoanApplications control = new LoanApplications();
            NavigateMenu(control);
        }

        private void navLoanHistory_Click(object sender, EventArgs e)
        {
            LoanHistory control = new LoanHistory();
            NavigateMenu(control);
        }

        private void navPayments_Click(object sender, EventArgs e)
        {
            PaymentsControl control = new PaymentsControl();
            NavigateMenu(control);
        }

        private void navLoanApplication_Click(object sender, EventArgs e)
        {
            LoanApplications control = new LoanApplications();
            NavigateMenu(control);
        }
    }
}


namespace WisejWebApplication1.Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new Wisej.Web.Panel();
            this.panelTopBar = new Wisej.Web.Panel();
            this.btnUser = new Wisej.Web.Button();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navDashboard = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navMySaving = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navMyLoan = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.index1 = new WisejWebApplication1.Dashboard.Index();
            this.panelMain.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.index1);
            this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(176, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1036, 793);
            this.panelMain.TabIndex = 0;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.btnUser);
            this.panelTopBar.CssStyle = "box-shadow: rgba(0, 0, 0, 0.15) 1.95px 1.95px 2.6px;";
            this.panelTopBar.Dock = Wisej.Web.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(176, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1036, 65);
            this.panelTopBar.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.FromName("@buttonText");
            this.btnUser.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnUser.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUser.ForeColor = System.Drawing.Color.FromName("@buttonFace");
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/round-account-button-with-user-inside.svg";
            this.btnUser.Location = new System.Drawing.Point(925, 7);
            this.btnUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Wisej.Web.Padding(8);
            this.btnUser.Size = new System.Drawing.Size(61, 52);
            this.btnUser.TabIndex = 1;
            this.btnUser.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            // 
            // menuItem1
            // 
            this.menuItem1.AllowHtml = true;
            this.menuItem1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuItem1.ForeColor = System.Drawing.Color.FromName("@buttonFace");
            this.menuItem1.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "<div style=\"padding: 8px\">Profile</div>";
            // 
            // menuItem2
            // 
            this.menuItem2.AllowHtml = true;
            this.menuItem2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuItem2.ForeColor = System.Drawing.Color.FromName("@buttonFace");
            this.menuItem2.IconSource = "resource.wx/Wisej.Ext.FontAwesome/reply.svg";
            this.menuItem2.Index = 1;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "<div style=\"padding: 8px\">Logout</div>";
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navDashboard,
            this.navMySaving,
            this.navMyLoan});
            this.navigationBar1.Logo = "Resources\\AFITlogo-1.gif";
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.ShowUser = false;
            this.navigationBar1.Size = new System.Drawing.Size(176, 858);
            this.navigationBar1.Text = "AFIT";
            this.navigationBar1.UserStatusColor = System.Drawing.Color.Transparent;
            // 
            // navDashboard
            // 
            this.navDashboard.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navDashboard.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navDashboard.Icon = "resource.wx/Wisej.Ext.FontAwesome/desktop.svg";
            this.navDashboard.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Text = "Dashboard";
            // 
            // navMySaving
            // 
            this.navMySaving.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navMySaving.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMySaving.Icon = "Resources\\wallet-solid.svg";
            this.navMySaving.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMySaving.Name = "navMySaving";
            this.navMySaving.Text = "My Savings";
            // 
            // navMyLoan
            // 
            this.navMyLoan.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navMyLoan.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMyLoan.Icon = "Resources\\piggy-bank-solid.svg";
            this.navMyLoan.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMyLoan.Name = "navMyLoan";
            this.navMyLoan.Text = "My Loan";
            // 
            // index1
            // 
            this.index1.Dock = Wisej.Web.DockStyle.Fill;
            this.index1.Name = "index1";
            this.index1.Size = new System.Drawing.Size(1036, 793);
            this.index1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 858);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.navigationBar1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.panelMain.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelMain;
        private Wisej.Web.Panel panelTopBar;
        private Index index1;
        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navDashboard;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navMySaving;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navMyLoan;
        private Wisej.Web.Button btnUser;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuItem2;
    }
}
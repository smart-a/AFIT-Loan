
namespace AFIT_Cooperative.Dashboard
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panelMain = new Wisej.Web.Panel();
            this.panelTopBar = new Wisej.Web.Panel();
            this.btnNavShow = new Wisej.Web.Button();
            this.btnUser = new Wisej.Web.Button();
            this.menuUser = new Wisej.Web.MenuItem();
            this.menuLogout = new Wisej.Web.MenuItem();
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navDashboard = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navMySaving = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navMyLoan = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(70, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(731, 793);
            this.panelMain.TabIndex = 0;
            this.panelMain.TabStop = true;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.btnNavShow);
            this.panelTopBar.Controls.Add(this.btnUser);
            this.panelTopBar.CssStyle = "box-shadow: rgba(0, 0, 0, 0.15) 1.95px 1.95px 2.6px;";
            this.panelTopBar.Dock = Wisej.Web.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(70, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(731, 65);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.TabStop = true;
            // 
            // btnNavShow
            // 
            this.btnNavShow.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.btnNavShow.BackColor = System.Drawing.Color.Transparent;
            this.btnNavShow.Focusable = false;
            this.btnNavShow.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnNavShow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/bars.svg";
            this.btnNavShow.Location = new System.Drawing.Point(16, 16);
            this.btnNavShow.Name = "btnNavShow";
            this.btnNavShow.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnNavShow.ResponsiveProfiles"))));
            this.btnNavShow.Size = new System.Drawing.Size(49, 37);
            this.btnNavShow.TabIndex = 9;
            this.btnNavShow.Tag = "show";
            this.btnNavShow.Click += new System.EventHandler(this.btnNavShow_Click);
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
            this.btnUser.Location = new System.Drawing.Point(650, 7);
            this.btnUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuUser,
            this.menuLogout});
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Wisej.Web.Padding(8);
            this.btnUser.Size = new System.Drawing.Size(61, 52);
            this.btnUser.TabIndex = 1;
            this.btnUser.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnUser.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.btnUser_ItemClicked);
            // 
            // menuUser
            // 
            this.menuUser.AllowHtml = true;
            this.menuUser.Enabled = false;
            this.menuUser.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.menuUser.Index = 0;
            this.menuUser.Name = "menuUser";
            this.menuUser.Text = "User name";
            // 
            // menuLogout
            // 
            this.menuLogout.AllowHtml = true;
            this.menuLogout.IconSource = "resource.wx/Wisej.Ext.FontAwesome/reply.svg";
            this.menuLogout.Index = 1;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Text = "Logout";
            // 
            // navigationBar1
            // 
            this.navigationBar1.CompactView = true;
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navDashboard,
            this.navMySaving,
            this.navMyLoan});
            this.navigationBar1.Logo = "Resources\\AFITlogo-1.gif";
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.ShowUser = false;
            this.navigationBar1.Size = new System.Drawing.Size(70, 858);
            this.navigationBar1.Text = "AFIT Cooperative";
            this.navigationBar1.UserStatusColor = System.Drawing.Color.Transparent;
            // 
            // navDashboard
            // 
            this.navDashboard.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navDashboard.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navDashboard.Icon = "resource.wx/Wisej.Ext.FontAwesome/desktop.svg";
            this.navDashboard.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Text = "Dashboard";
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // navMySaving
            // 
            this.navMySaving.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navMySaving.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMySaving.Icon = "Resources\\wallet-solid.svg";
            this.navMySaving.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMySaving.Name = "navMySaving";
            this.navMySaving.Text = "My Savings";
            this.navMySaving.Click += new System.EventHandler(this.navMySaving_Click);
            // 
            // navMyLoan
            // 
            this.navMyLoan.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.navMyLoan.ForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMyLoan.Icon = "Resources\\piggy-bank-solid.svg";
            this.navMyLoan.InfoTextForeColor = System.Drawing.Color.FromName("@navbar-text");
            this.navMyLoan.Name = "navMyLoan";
            this.navMyLoan.Text = "My Loan";
            this.navMyLoan.Click += new System.EventHandler(this.navMyLoan_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 858);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.navigationBar1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelMain;
        private Wisej.Web.Panel panelTopBar;
        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navDashboard;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navMySaving;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navMyLoan;
        private Wisej.Web.Button btnUser;
        private Wisej.Web.MenuItem menuUser;
        private Wisej.Web.MenuItem menuLogout;
        private Wisej.Web.Button btnNavShow;
    }
}
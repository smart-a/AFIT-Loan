
namespace AFIT_Cooperative
{
    partial class DefaultHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultHeader));
            this.panel8 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.btnSignUp = new Wisej.Web.Button();
            this.btnHome = new Wisej.Web.Button();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.btnSignUp);
            this.panel8.Controls.Add(this.btnHome);
            this.panel8.CssStyle = "box-shadow: rgba(0, 0, 0, 0.15) 1.95px 1.95px 2.6px;";
            this.panel8.Dock = Wisej.Web.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.MinimumSize = new System.Drawing.Size(500, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1292, 86);
            this.panel8.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.CssStyle = "background-color: transparent";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnSignUp.Cursor = Wisej.Web.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(11, 93, 171);
            this.btnSignUp.Location = new System.Drawing.Point(1149, 32);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(91, 22);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnHome.Cursor = Wisej.Web.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(11, 93, 171);
            this.btnHome.Location = new System.Drawing.Point(1073, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(76, 22);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // DefaultHeader
            // 
            this.Controls.Add(this.panel8);
            this.CssStyle = "box-shadow: rgba(0, 0, 0, 0.15) 1.95px 1.95px 2.6px;";
            this.Dock = Wisej.Web.DockStyle.Top;
            this.Name = "DefaultHeader";
            this.Size = new System.Drawing.Size(1292, 86);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel8;
        private Wisej.Web.PictureBox pictureBox1;
        public Wisej.Web.Button btnSignUp;
        private Wisej.Web.Button btnHome;
    }
}


namespace AFIT_Cooperative
{
    partial class ForgetPassword
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
            this.btnSubmit = new Wisej.Web.Button();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtCPassword = new Wisej.Web.TextBox();
            this.btnReset = new Wisej.Web.Button();
            this.panelUserInfo = new Wisej.Web.Panel();
            this.txtStaffNumber = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSubmit.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSubmit.Location = new System.Drawing.Point(238, 121);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 45);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = Wisej.Web.AnchorStyles.Left;
            this.txtPassword.CssStyle = "border-radius: 3px";
            this.txtPassword.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.LabelText = "New Password";
            this.txtPassword.Location = new System.Drawing.Point(48, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(12);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 68);
            this.txtPassword.TabIndex = 36;
            this.txtPassword.Watermark = "Enter New Password";
            // 
            // txtCPassword
            // 
            this.txtCPassword.Anchor = Wisej.Web.AnchorStyles.Left;
            this.txtCPassword.CssStyle = "border-radius: 3px";
            this.txtCPassword.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtCPassword.LabelText = "Confirm Password";
            this.txtCPassword.Location = new System.Drawing.Point(50, 294);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Padding = new Wisej.Web.Padding(12);
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(300, 68);
            this.txtCPassword.TabIndex = 37;
            this.txtCPassword.Watermark = "Confirm Password";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnReset.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnReset.Location = new System.Drawing.Point(49, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(299, 42);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset Password";
            this.btnReset.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.txtStaffNumber);
            this.panelUserInfo.Controls.Add(this.txtEmail);
            this.panelUserInfo.Controls.Add(this.btnSubmit);
            this.panelUserInfo.Location = new System.Drawing.Point(27, 3);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(340, 180);
            this.panelUserInfo.TabIndex = 39;
            this.panelUserInfo.TabStop = true;
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.CssStyle = "border-radius: 3px";
            this.txtStaffNumber.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStaffNumber.LabelText = "Staff Number";
            this.txtStaffNumber.Location = new System.Drawing.Point(21, 98);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Padding = new Wisej.Web.Padding(12);
            this.txtStaffNumber.Size = new System.Drawing.Size(212, 68);
            this.txtStaffNumber.TabIndex = 37;
            this.txtStaffNumber.Watermark = "Enter Staff Number";
            // 
            // txtEmail
            // 
            this.txtEmail.CssStyle = "border-radius: 3px";
            this.txtEmail.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.InputType.Type = Wisej.Web.TextBoxType.Email;
            this.txtEmail.LabelText = "Email Address";
            this.txtEmail.Location = new System.Drawing.Point(22, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Wisej.Web.Padding(12);
            this.txtEmail.Size = new System.Drawing.Size(300, 68);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.Watermark = "Enter Email Address";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 451);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Button btnSubmit;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtCPassword;
        private Wisej.Web.Button btnReset;
        private Wisej.Web.Panel panelUserInfo;
        private Wisej.Web.TextBox txtStaffNumber;
        private Wisej.Web.TextBox txtEmail;
    }
}
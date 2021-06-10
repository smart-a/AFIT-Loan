
namespace AFIT_Cooperative.Dashboard
{
    partial class PayLoan
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
            this.panel1 = new Wisej.Web.Panel();
            this.cbPayMode = new Wisej.Web.ComboBox();
            this.txtAmount = new Wisej.Web.TextBox();
            this.btnSave = new Wisej.Web.Button();
            this.panelOption = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPayMode);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(315, 76);
            this.panel1.TabIndex = 18;
            this.panel1.TabStop = true;
            this.panel1.Text = "Subscription";
            // 
            // cbPayMode
            // 
            this.cbPayMode.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
            this.cbPayMode.AutoSize = false;
            this.cbPayMode.CssStyle = "padding: 10px;";
            this.cbPayMode.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbPayMode.Location = new System.Drawing.Point(13, 3);
            this.cbPayMode.Name = "cbPayMode";
            this.cbPayMode.Size = new System.Drawing.Size(298, 42);
            this.cbPayMode.TabIndex = 9;
            this.cbPayMode.Watermark = "Select Subscription";
            this.cbPayMode.SelectedIndexChanged += new System.EventHandler(this.cbPayMode_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.CssStyle = "border-radius: 3px";
            this.txtAmount.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.LabelText = "Amount";
            this.txtAmount.Location = new System.Drawing.Point(13, 15);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new Wisej.Web.Padding(12);
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(298, 68);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.Text = "0";
            this.txtAmount.Watermark = "Enter Fullname";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSave.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/lock.svg";
            this.btnSave.Location = new System.Drawing.Point(11, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 42);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Pay N0.00";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.btnSave);
            this.panelOption.Controls.Add(this.txtAmount);
            this.panelOption.Enabled = false;
            this.panelOption.Location = new System.Drawing.Point(13, 111);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(315, 171);
            this.panelOption.TabIndex = 22;
            this.panelOption.TabStop = true;
            // 
            // PayLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 300);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayLoad";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Pay Load";
            this.Load += new System.EventHandler(this.PayLoad_Load);
            this.panel1.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox cbPayMode;
        private Wisej.Web.TextBox txtAmount;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.Panel panelOption;
    }
}
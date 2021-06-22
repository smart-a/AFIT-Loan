
namespace AFIT_Cooperative.Dashboard
{
    partial class ApplyLoan
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
            this.panel2 = new Wisej.Web.Panel();
            this.nudAmount = new Wisej.Web.NumericUpDown();
            this.panel1 = new Wisej.Web.Panel();
            this.cbPayPeriod = new Wisej.Web.ComboBox();
            this.txtAmountPayable = new Wisej.Web.TextBox();
            this.txtMonthlyPay = new Wisej.Web.TextBox();
            this.btnApply = new Wisej.Web.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudAmount);
            this.panel2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel2.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel2.Location = new System.Drawing.Point(45, 16);
            this.panel2.Name = "panel2";
            this.panel2.ShowCloseButton = false;
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(314, 76);
            this.panel2.TabIndex = 30;
            this.panel2.TabStop = true;
            this.panel2.Text = "Amount (NGN)";
            // 
            // nudAmount
            // 
            this.nudAmount.AutoSize = false;
            this.nudAmount.CssStyle = "border-radius: 3px";
            this.nudAmount.Location = new System.Drawing.Point(4, 3);
            this.nudAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(300, 42);
            this.nudAmount.TabIndex = 0;
            this.nudAmount.KeyPress += new Wisej.Web.KeyPressEventHandler(this.nudAmount_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPayPeriod);
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel1.Location = new System.Drawing.Point(44, 98);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(315, 76);
            this.panel1.TabIndex = 31;
            this.panel1.TabStop = true;
            this.panel1.Text = "Payment Period";
            // 
            // cbPayPeriod
            // 
            this.cbPayPeriod.AutoSize = false;
            this.cbPayPeriod.CssStyle = "padding: 10px;";
            this.cbPayPeriod.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbPayPeriod.Location = new System.Drawing.Point(5, 3);
            this.cbPayPeriod.Name = "cbPayPeriod";
            this.cbPayPeriod.Size = new System.Drawing.Size(300, 42);
            this.cbPayPeriod.TabIndex = 9;
            this.cbPayPeriod.Watermark = "Select Payment Period";
            this.cbPayPeriod.SelectedItemChanged += new System.EventHandler(this.cbPayPeriod_SelectedItemChanged);
            // 
            // txtAmountPayable
            // 
            this.txtAmountPayable.CssStyle = "border-radius: 3px";
            this.txtAmountPayable.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmountPayable.LabelText = "Total Amount Payable  (NGN)";
            this.txtAmountPayable.Location = new System.Drawing.Point(49, 185);
            this.txtAmountPayable.Name = "txtAmountPayable";
            this.txtAmountPayable.Padding = new Wisej.Web.Padding(12);
            this.txtAmountPayable.ReadOnly = true;
            this.txtAmountPayable.Size = new System.Drawing.Size(300, 68);
            this.txtAmountPayable.TabIndex = 32;
            this.txtAmountPayable.Text = "0";
            this.txtAmountPayable.Watermark = "Enter Fullname";
            // 
            // txtMonthlyPay
            // 
            this.txtMonthlyPay.CssStyle = "border-radius: 3px";
            this.txtMonthlyPay.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMonthlyPay.LabelText = "Monthly Payable (NGN)";
            this.txtMonthlyPay.Location = new System.Drawing.Point(49, 263);
            this.txtMonthlyPay.Name = "txtMonthlyPay";
            this.txtMonthlyPay.Padding = new Wisej.Web.Padding(12);
            this.txtMonthlyPay.ReadOnly = true;
            this.txtMonthlyPay.Size = new System.Drawing.Size(300, 68);
            this.txtMonthlyPay.TabIndex = 33;
            this.txtMonthlyPay.Text = "0";
            this.txtMonthlyPay.Watermark = "Enter Fullname";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnApply.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnApply.Location = new System.Drawing.Point(49, 354);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(300, 42);
            this.btnApply.TabIndex = 34;
            this.btnApply.Text = "Submit Application";
            this.btnApply.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ApplyLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 418);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtMonthlyPay);
            this.Controls.Add(this.txtAmountPayable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IconSource = "(none)resource.wx/Wisej.Ext.FontAwesome/check-square-o.svg";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyLoan";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Apply Loan";
            this.Load += new System.EventHandler(this.ApplyLoan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel2;
        public Wisej.Web.NumericUpDown nudAmount;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.ComboBox cbPayPeriod;
        private Wisej.Web.TextBox txtAmountPayable;
        private Wisej.Web.TextBox txtMonthlyPay;
        private Wisej.Web.Button btnApply;
    }
}
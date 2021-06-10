
namespace AFIT_Cooperative.Dashboard
{
    partial class Index
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
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.panel4 = new Wisej.Web.Panel();
            this.panel5 = new Wisej.Web.Panel();
            this.btnApply = new Wisej.Web.Button();
            this.btnPayNow = new Wisej.Web.Button();
            this.label7 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label2 = new Wisej.Web.Label();
            this.lblWallet = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.btnStatusIndicator = new Wisej.Web.Button();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.label3 = new Wisej.Web.Label();
            this.lblLoanAmount = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.label5 = new Wisej.Web.Label();
            this.lblLoanBalance = new Wisej.Web.Label();
            this.flexLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.AutoScroll = true;
            this.flexLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.flexLayoutPanel1.Controls.Add(this.panel4);
            this.flexLayoutPanel1.Controls.Add(this.flowLayoutPanel1);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(1000, 809);
            this.flexLayoutPanel1.TabIndex = 1;
            this.flexLayoutPanel1.TabStop = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 577);
            this.panel4.TabIndex = 1;
            this.panel4.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel5.Controls.Add(this.btnApply);
            this.panel5.Controls.Add(this.btnPayNow);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.CssStyle = "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\r\nborder-radius: 4px";
            this.panel5.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel5.HeaderBackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel5.HeaderForeColor = System.Drawing.Color.FromName("@controlText");
            this.panel5.Location = new System.Drawing.Point(83, 17);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Wisej.Web.Padding(8);
            this.panel5.ShowCloseButton = false;
            this.panel5.Size = new System.Drawing.Size(814, 533);
            this.panel5.TabIndex = 2;
            this.panel5.TabStop = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnApply.Focusable = false;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/check-square-o.svg";
            this.btnApply.Location = new System.Drawing.Point(542, 23);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(129, 30);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply Loan";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnPayNow
            // 
            this.btnPayNow.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnPayNow.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnPayNow.Focusable = false;
            this.btnPayNow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayNow.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/paypal.svg";
            this.btnPayNow.Location = new System.Drawing.Point(686, 23);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(102, 30);
            this.btnPayNow.TabIndex = 9;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(26, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loan Histroy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(26, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(80, 50, 80, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 211);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblWallet);
            this.panel1.CssStyle = "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\r\nborder-radius: 4px";
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.Location = new System.Drawing.Point(83, 53);
            this.panel1.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(256, 123);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.ImageSource = "Resources\\wallet-solid.svg";
            this.pictureBox1.Location = new System.Drawing.Point(166, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            // 
            // label2
            // 
            this.label2.AllowHtml = true;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "<h2>My Savings</h2>";
            // 
            // lblWallet
            // 
            this.lblWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWallet.ForeColor = System.Drawing.Color.Green;
            this.lblWallet.Location = new System.Drawing.Point(104, 86);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.RightToLeft = Wisej.Web.RightToLeft.Yes;
            this.lblWallet.Size = new System.Drawing.Size(130, 19);
            this.lblWallet.TabIndex = 0;
            this.lblWallet.Text = "N0.00";
            this.lblWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel2.Controls.Add(this.btnStatusIndicator);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblLoanAmount);
            this.panel2.CssStyle = "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\r\nborder-radius: 4px";
            this.panel2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.Location = new System.Drawing.Point(362, 53);
            this.panel2.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(256, 123);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // btnStatusIndicator
            // 
            this.btnStatusIndicator.AutoSize = true;
            this.btnStatusIndicator.BackColor = System.Drawing.Color.Transparent;
            this.btnStatusIndicator.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnStatusIndicator.CssStyle = "box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.btnStatusIndicator.Focusable = false;
            this.btnStatusIndicator.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStatusIndicator.ForeColor = System.Drawing.Color.Green;
            this.btnStatusIndicator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatusIndicator.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/dot-circle-o.svg";
            this.btnStatusIndicator.Location = new System.Drawing.Point(4, 92);
            this.btnStatusIndicator.Name = "btnStatusIndicator";
            this.btnStatusIndicator.Size = new System.Drawing.Size(89, 27);
            this.btnStatusIndicator.TabIndex = 3;
            this.btnStatusIndicator.Text = "Active";
            this.btnStatusIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.pictureBox2.ImageSource = "Resources\\piggy-bank-solid.svg";
            this.pictureBox2.Location = new System.Drawing.Point(166, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 54);
            // 
            // label3
            // 
            this.label3.AllowHtml = true;
            this.label3.Location = new System.Drawing.Point(26, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 57);
            this.label3.TabIndex = 1;
            this.label3.Text = "<h2>My Loan</h2>";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoanAmount.ForeColor = System.Drawing.Color.Green;
            this.lblLoanAmount.Location = new System.Drawing.Point(127, 86);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.RightToLeft = Wisej.Web.RightToLeft.Yes;
            this.lblLoanAmount.Size = new System.Drawing.Size(107, 19);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "N0.00";
            this.lblLoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblLoanBalance);
            this.panel3.CssStyle = "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\r\nborder-radius: 4px";
            this.panel3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.Location = new System.Drawing.Point(641, 53);
            this.panel3.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(5);
            this.panel3.Size = new System.Drawing.Size(256, 123);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ForeColor = System.Drawing.Color.FromArgb(218, 165, 32);
            this.pictureBox3.ImageSource = "resource.wx/Wisej.Ext.ModernUI/appbar.money.svg";
            this.pictureBox3.Location = new System.Drawing.Point(166, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 54);
            // 
            // label5
            // 
            this.label5.AllowHtml = true;
            this.label5.Location = new System.Drawing.Point(26, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 57);
            this.label5.TabIndex = 1;
            this.label5.Text = "<h2>My Balance</h2>";
            // 
            // lblLoanBalance
            // 
            this.lblLoanBalance.Anchor = Wisej.Web.AnchorStyles.Top;
            this.lblLoanBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoanBalance.ForeColor = System.Drawing.Color.Green;
            this.lblLoanBalance.Location = new System.Drawing.Point(128, 86);
            this.lblLoanBalance.Name = "lblLoanBalance";
            this.lblLoanBalance.RightToLeft = Wisej.Web.RightToLeft.Yes;
            this.lblLoanBalance.Size = new System.Drawing.Size(106, 19);
            this.lblLoanBalance.TabIndex = 0;
            this.lblLoanBalance.Text = "N0.00";
            this.lblLoanBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Index
            // 
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(1000, 809);
            this.Appear += new System.EventHandler(this.Index_Appear);
            this.flexLayoutPanel1.ResumeLayout(false);
            this.flexLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lblWallet;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label lblLoanAmount;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.PictureBox pictureBox3;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label lblLoanBalance;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Label label7;
        private Wisej.Web.Button btnApply;
        private Wisej.Web.Button btnPayNow;
        private Wisej.Web.Button btnStatusIndicator;
    }
}

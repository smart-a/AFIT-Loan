
namespace AFIT_Cooperative.Dashboard
{
    partial class MySavings
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySavings));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.btnFundWallet = new Wisej.Web.Button();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.lblWallet = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.panel5 = new Wisej.Web.Panel();
            this.btnRefresh = new Wisej.Web.Button();
            this.dtpTo = new Wisej.Web.DateTimePicker();
            this.dtpFrom = new Wisej.Web.DateTimePicker();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.label3 = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel1.Controls.Add(this.btnFundWallet);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblWallet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.CssStyle = "box-shadow: rgba(100, 100, 111, 0.2) 0px 7px 29px 0px;\r\nborder-radius: 4px";
            this.panel1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.Location = new System.Drawing.Point(27, 44);
            this.panel1.Margin = new Wisej.Web.Padding(3, 3, 20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(747, 78);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // btnFundWallet
            // 
            this.btnFundWallet.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnFundWallet.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnFundWallet.Focusable = false;
            this.btnFundWallet.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/plus-circle.svg";
            this.btnFundWallet.Location = new System.Drawing.Point(597, 24);
            this.btnFundWallet.Name = "btnFundWallet";
            this.btnFundWallet.Size = new System.Drawing.Size(130, 30);
            this.btnFundWallet.TabIndex = 3;
            this.btnFundWallet.Text = "Fund Wallet";
            this.btnFundWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundWallet.Click += new System.EventHandler(this.btnFundWallet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.ImageSource = "Resources\\wallet-solid.svg";
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWallet.ForeColor = System.Drawing.Color.Green;
            this.lblWallet.Location = new System.Drawing.Point(234, 33);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(52, 21);
            this.lblWallet.TabIndex = 0;
            this.lblWallet.Text = "N0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(81, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Savings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.dtpTo);
            this.panel5.Controls.Add(this.dtpFrom);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(27, 144);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(747, 606);
            this.panel5.TabIndex = 15;
            this.panel5.TabStop = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(234, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpTo.LabelText = "To";
            this.dtpTo.Location = new System.Drawing.Point(126, 94);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 44);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.Value = new System.DateTime(2021, 5, 16, 16, 40, 56, 708);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFrom.LabelText = "From";
            this.dtpFrom.Location = new System.Drawing.Point(22, 94);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(98, 44);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.Value = new System.DateTime(2021, 5, 16, 16, 40, 56, 708);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/history.svg";
            this.pictureBox2.Location = new System.Drawing.Point(22, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label3.Location = new System.Drawing.Point(76, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fund\'s History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(22, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView1.ResponsiveProfiles"))));
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(697, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // MySavings
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "MySavings";
            this.Size = new System.Drawing.Size(800, 792);
            this.Load += new System.EventHandler(this.MySavings_Load);
            this.Appear += new System.EventHandler(this.MySavings_Appear);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnFundWallet;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Label lblWallet;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.DateTimePicker dtpTo;
        private Wisej.Web.DateTimePicker dtpFrom;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Label label3;
        private Wisej.Web.DataGridView dataGridView1;
    }
}

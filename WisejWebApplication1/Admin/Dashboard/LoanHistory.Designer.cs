
namespace AFIT_Cooperative.Admin.Dashboard
{
    partial class LoanHistory
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanHistory));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.btnRefresh = new Wisej.Web.Button();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.label2 = new Wisej.Web.Label();
            this.txtSearch = new Wisej.Web.TextBox();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(49, 45);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(701, 614);
            this.panel1.TabIndex = 13;
            this.panel1.TabStop = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(272, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/history.svg";
            this.pictureBox2.Location = new System.Drawing.Point(24, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label2.Location = new System.Drawing.Point(76, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loan History";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(24, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new Wisej.Web.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(235, 30);
            this.txtSearch.TabIndex = 3;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/search.svg";
            this.txtSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.txtSearch.Watermark = "Staff number or name";
            this.txtSearch.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(24, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView2.ResponsiveProfiles"))));
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(651, 428);
            this.dataGridView2.TabIndex = 0;
            // 
            // LoanHistory
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Name = "LoanHistory";
            this.Size = new System.Drawing.Size(800, 726);
            this.Appear += new System.EventHandler(this.BooksControl_Appear);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.PictureBox pictureBox2;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox txtSearch;
        private Wisej.Web.DataGridView dataGridView2;
    }
}


namespace AFIT_Cooperative.Admin.Dashboard
{
    partial class LoanApplications
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanHistory));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel5 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView1.ResponsiveProfiles"))));
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(651, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loan Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.pictureBox1.ImageSource = "Resources\\piggy-bank-solid.svg";
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            // 
            // panel5
            // 
            this.panel5.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(49, 39);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(701, 557);
            this.panel5.TabIndex = 12;
            this.panel5.TabStop = true;
            // 
            // LoanApplications
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.panel5);
            this.Name = "LoanApplications";
            this.Size = new System.Drawing.Size(800, 618);
            this.Appear += new System.EventHandler(this.BooksControl_Appear);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Label label1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Panel panel5;
    }
}

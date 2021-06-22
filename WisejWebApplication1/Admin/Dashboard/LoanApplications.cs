using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Admin.Dashboard
{
    public partial class LoanApplications : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;

        public LoanApplications()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        public void LoadApplications()
        {
            var applicationList = _context.Loans.Where((l) => l.Status == 0)
                .OrderByDescending((i) => i.Date).ToList();
            var loanList = applicationList.Select((h) =>
                new LoanDisplay
                {
                    Id = h.Id,
                    StaffNumber = h.Member.StaffNumber,
                    Fullname = h.Member.Fullname,
                    Amount = h.Amount.ToString("###,##0.00"),
                    AmountPayable = h.AmountPayable.ToString("###,##0.00"),
                    MonthlyPay = h.MonthlyPay.ToString("###,##0.00"),
                    Balance = h.Balance.ToString("###,##0.00"),
                    Duration = $"{h.Duration} months",
                    Status = h.Status == 0 ? "Pending" : h.Status == 1 ? "Active" : "Declined",
                    Date = h.Date.Value.ToString("dd MMM, yyyy")
                }).ToList();

            dataGridView1.DataSource = loanList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Fullname"].Width = 200;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
            var selectedLoan = _context.Loans.SingleOrDefault((b) => b.Id == index);
            if (selectedLoan != null)
            {
                LoanDetails loanDetails = new LoanDetails(selectedLoan);
                loanDetails.ShowDialog();
                LoadApplications();
            }
        }

        private void BooksControl_Appear(object sender, EventArgs e)
        {
            LoadApplications();
        }
    }
}

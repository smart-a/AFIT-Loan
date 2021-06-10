using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Admin.Dashboard
{
    public partial class LoanHistory : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;

        public LoanHistory()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        public void LoadLoanHistory(List<Loan> param = null)
        {
            var loanList = param;
            if (loanList == null || loanList.Count < 1)
            {
                _context = new ApplicationDbContext();
                loanList = _context.Loans.Where((l) => l.Status == 1)
                    .OrderByDescending((i) => i.Date).ToList();
            }

            var histories = loanList.Select((h) =>
                new LoanDisplay
                {
                    Id = h.Id,
                    Fullname = h.Member.Fullname,
                    Amount = h.Amount.ToString("###,##0.00"),
                    AmountPayable = h.AmountPayable.ToString("###,##0.00"),
                    MonthlyPay = h.MonthlyPay.ToString("###,##0.00"),
                    Balance = h.Balance.ToString("###,##0.00"),
                    Duration = $"{h.Duration}ms",
                    Status = h.Status == 0 ? "Pending" : h.Status == 1 ? "Active" : "Declined",
                    Date = h.Date.Value.ToString("dd MMM, yyyy")
                }).ToList();

            dataGridView2.DataSource = histories;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Fullname"].Width = 200;
        }

        private void BooksControl_Appear(object sender, EventArgs e)
        {
            LoadLoanHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadLoanHistory();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var search = txtSearch.Text;
            if (search == "")
            {
                LoadLoanHistory();
                return;
            }
            var bookList = _context.Loans.ToList();
            bookList = bookList.Where((b) =>
               b.Member.StaffNumber.StartsWith(search, StringComparison.OrdinalIgnoreCase) ||
               b.Member.Fullname.StartsWith(search, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadLoanHistory(bookList);
        }
    }
}

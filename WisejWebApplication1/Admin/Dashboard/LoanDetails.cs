using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Wisej.Web;

namespace AFIT_Cooperative.Admin.Dashboard
{
    public partial class LoanDetails : Form
    {
        ApplicationDbContext _context;
        Loan _loan;

        public LoanDetails(Loan loan)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _loan = loan;
        }

        private void LoanDetails_Load(object sender, EventArgs e)
        {
            lblDate.Text = _loan.Date.Value.ToString("dd MMM, yyyy");
            lblStaffNumber.Text = _loan.Member.StaffNumber;
            lblFullname.Text = _loan.Member.Fullname;
            lblAmount.Text = _loan.Amount.ToString("###,##0.00");
            lblPayable.Text = _loan.AmountPayable.ToString("###,##0.00");
            lblMonthlyPay.Text = _loan.MonthlyPay.ToString("###,##0.00");
            lblDuration.Text = $"{_loan.Duration} months";

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Approve Loan Application",
                buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                UpdateLoan(1).Wait();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Decline Loan Application",
               buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                UpdateLoan(-1).Wait();
            }
        }

        private async Task UpdateLoan(int status)
        {
            try
            {
                var loan = _context.Loans.SingleOrDefault((l) => l.Id == _loan.Id);
                loan.Status = status;
                _context.Entry(loan).State = System.Data.Entity.EntityState.Modified;
                await _context.SaveChangesAsync();
                MessageBox.Show("Loan application successful");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

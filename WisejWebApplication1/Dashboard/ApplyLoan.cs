using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Dashboard //LoanApplications
{
    public partial class ApplyLoan : Form
    {
        const double PERCENTAGE_INT = 6;
        ApplicationDbContext _context;
        Account _account;

        public ApplyLoan(Account account)
        {
            InitializeComponent();
            _account = account;
            _context = new ApplicationDbContext();
        }

        private void ApplyLoan_Load(object sender, EventArgs e)
        {
            string[] period = { "3 months", "6 months", "9 months", "12 months" };
            cbPayPeriod.DataSource = period;
            cbPayPeriod.Text = "";
        }

        private void CalculateLoan()
        {
            if (cbPayPeriod.Text != "" && nudAmount.Value > 0)
            {
                var period = int.Parse(cbPayPeriod.Text);
                var step = cbPayPeriod.SelectedIndex + 1;
                var amountApply = double.Parse(nudAmount.Value.ToString());

                var payable = amountApply + (amountApply * (PERCENTAGE_INT / 100) * step);
                var monthlyPay = payable / period;
                txtAmountPayable.Text = payable.ToString("###,##0.00");
                txtMonthlyPay.Text = monthlyPay.ToString("###,##0.00");
            }
        }

        private void cbPayPeriod_SelectedItemChanged(object sender, EventArgs e)
        {
            CalculateLoan();
        }

        private void nudAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateLoan();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var maxApplication = _account.Wallet * 5;
            var amountApply = double.Parse(nudAmount.Value.ToString());
            var payable = double.Parse(txtAmountPayable.Text.Replace(",", ""));
            var period = int.Parse(cbPayPeriod.Text);
            var monthlyPay = payable / period;
            if (amountApply > maxApplication)
            {
                MessageBox.Show("Sorry!!! You can only apply for 500% of your current savings\n" +
                    $"Maximun of {maxApplication.ToString("N###,##0.00")}");
                nudAmount.Focus();
                return;
            }

            var member = _context.Members.SingleOrDefault((m) => m.Id == _account.Member.Id);
            Loan loan = new Loan
            {
                Member = member,
                Amount = amountApply,
                AmountPayable = payable,
                MonthlyPay = monthlyPay,
                Date = DateTime.Now,
                Balance = payable,
                Duration = period
            };
            _context.Loans.Add(loan);
            _context.SaveChanges();

            var account = _context.Accounts.SingleOrDefault((a) => a.Id == _account.Id);
            account.Loan = loan;
            _context.Entry(account).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

            MessageBox.Show("Loan application successful\nKindly wait for an approval");
            this.Dispose();
        }
    }
}

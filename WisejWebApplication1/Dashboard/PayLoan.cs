using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Dashboard
{
    public partial class PayLoan : Form
    {
        ApplicationDbContext _context;
        Account _account;

        public PayLoan(Account account)
        {
            InitializeComponent();
            _account = account;
            _context = new ApplicationDbContext();
        }

        private void PayLoad_Load(object sender, EventArgs e)
        {
            cbPayMode.DataSource = new string[] { "Pay from Wallet", "Pay with card" };
            cbPayMode.Text = "";
            txtAmount.Text = _account.Loan.MonthlyPay.ToString();
            btnSave.Text = $"Pay N{_account.Loan.MonthlyPay.ToString("###,##0.00")}";
        }

        private void MakePayment(double amount)
        {
            var loan = _context.Loans.SingleOrDefault((l) => l.Id == _account.Loan.Id);
            loan.Balance -= amount;
            _context.Entry(loan).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

            var member = _context.Members.SingleOrDefault((m) => m.Id == _account.Member.Id);
            _context.LoanPaymentHistories.Add(new LoanPaymentHistory
            {
                Member = member,
                Loan = loan,
                PaymentMode = cbPayMode.Text,
                Amount = amount,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            MessageBox.Show("Payment successful");
            this.Dispose();
        }

        private void cbPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPayMode.SelectedIndex == 0)
            {
                panelOption.Enabled = true;
            }
            else if(cbPayMode.SelectedIndex == 1)
            {
                panelOption.Enabled = false;
                FundWallet fund = new FundWallet();
                fund.Text = "Pay Loan";
                fund.nudAmount.Value = decimal.Parse(_account.Loan.MonthlyPay.ToString());
                fund.nudAmount.ReadOnly = true;
                fund.ShowDialog();

                if (fund.IsSuccess)
                {
                    var amount = double.Parse(fund.PaidAmount.ToString());
                    MakePayment(amount);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var amount = double.Parse(txtAmount.Text);
            if(amount > _account.Wallet)
            {
                MessageBox.Show("Insufficient wallet balance");
                return;
            }
            var account = _context.Accounts.SingleOrDefault((m) => m.Id == _account.Id);
            account.Wallet -= amount;
            _context.Entry(account).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            MakePayment(amount);
        }
    }
}

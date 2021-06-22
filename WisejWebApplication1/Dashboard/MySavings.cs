using AFIT_Cooperative.Data;
using AFIT_Cooperative.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace AFIT_Cooperative.Dashboard
{
    public partial class MySavings : UserControl
    {
        ApplicationDbContext _context;
        Member currentMember;
        Account account;

        public MySavings(Member member)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            currentMember = member;
        }

        private void MySavings_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void MySavings_Appear(object sender, EventArgs e)
        {
            account = _context.Accounts.SingleOrDefault((a) => a.Member.Id == currentMember.Id);
            lblWallet.Text = account.Wallet.ToString("N###,##0.00");
            LoadHistory();
        }

        public void LoadHistory(List<PaymentHistory> param = null)
        {
            var hList = param;
            if (hList == null || hList.Count < 1)
            {
                hList = _context.PaymentHistories.Where((h) => h.Member.Id == currentMember.Id).ToList();
            }

            var histories = hList.Select((h) =>
                new PaymentHistoryDisplay
                {
                    Id = h.Id,
                    Fullname = h.Member.Fullname,
                    Amount = h.Amount.ToString("###,##0.00"),
                    Date = h.PaidAt.ToString("dd MMM, yyyy")
                }).ToList();

            dataGridView1.DataSource = histories;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Fullname"].Width = 200;
        }

        private void Filter()
        {
            var start = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day);
            var end = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day);

            var hList = _context.PaymentHistories.Where((h) => h.Member.Id == currentMember.Id).ToList();
            var histories = hList.Where((h) =>
                start >= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day) &&
                end <= new DateTime(h.PaidAt.Year, h.PaidAt.Month, h.PaidAt.Day)).ToList();

            LoadHistory(histories);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            LoadHistory();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnFundWallet_Click(object sender, EventArgs e)
        {
            try
            {
                FundWallet fundWallet = new FundWallet();
                fundWallet.ShowDialog();
                if (fundWallet.IsSuccess)
                {
                    var amount = double.Parse(fundWallet.PaidAmount.ToString());
                    account = _context.Accounts.SingleOrDefault((a) => a.Member.Id == currentMember.Id);
                    account.Wallet += amount;
                    _context.Entry(account).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                    var member = _context.Members.SingleOrDefault((a) => a.Id == currentMember.Id);
                    _context.PaymentHistories.Add(new PaymentHistory
                    {
                        Member = member,
                        Amount = amount,
                        PaidAt = DateTime.Now
                    });
                    _context.SaveChanges();

                    LoadHistory();
                    lblWallet.Text = account.Wallet.ToString("N###,##0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} - {ex.StackTrace}");
            }
        }
    }
}

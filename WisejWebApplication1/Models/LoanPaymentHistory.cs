using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFIT_Cooperative.Models
{
    public class LoanPaymentHistory
    {
        public LoanPaymentHistory()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public virtual Member Member { set; get; }
        public virtual Loan Loan { set; get; }
        public string PaymentMode { set; get; }
        public double Amount { set; get; }
        public DateTime? Date { set; get; }
    }

    public class LoanPaymentHistoryDisplay
    {
        public Guid Id { set; get; }
        public string Fullname { set; get; }
        public string Amount { set; get; }
        public string AmountPayable { set; get; }
        public string Balance { set; get; }
        public string PaymentMode { set; get; }
        public string Date { set; get; }
    }
}
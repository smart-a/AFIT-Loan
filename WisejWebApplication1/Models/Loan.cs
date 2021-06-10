using System;

namespace AFIT_Cooperative.Models
{
    public class Loan
    {
        public Loan()
        {
            Id = Guid.NewGuid();
            Status = 0;
        }

        public Guid Id { set; get; }
        public virtual Member Member { set; get; }
        public double Amount { set; get; }
        public double AmountPayable { set; get; }
        public double MonthlyPay { set; get; }
        public double Balance { set; get; }
        public int Duration { set; get; }
        public int Status  { set; get; }
        public DateTime? Date { set; get; }
    }

    public class LoanDisplay
    {
        public Guid Id { set; get; }
        public string Fullname { set; get; }
        public string Amount { set; get; }
        public string AmountPayable { set; get; }
        public string MonthlyPay { set; get; }
        public string Balance { set; get; }
        public string Duration { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }
    }
}
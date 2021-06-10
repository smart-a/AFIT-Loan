using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFIT_Cooperative.Models
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
            Wallet = 0;
        }

        public Guid Id { set; get; }
        public virtual Member Member { set; get; }
        public double Wallet { set; get; }
        public virtual Loan Loan  { set; get; }
    }
}
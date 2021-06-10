using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;
using AFIT_Cooperative.Models;

namespace AFIT_Cooperative.Data
{

    public class ApplicationDbContext : DbContext
    {
#if DEBUG
        public ApplicationDbContext()
        : base("Server=(localdb)\\mssqllocaldb;Database=afit;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
            var ad = this.UsersAccounts.Count();
            if (ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount { Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        }
#else
        public ApplicationDbContext()
           : base("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75b55_childabuse;User Id=db_a75b55_childabuse_admin;Password=Horlarlekhan1#")
        {
            var ad = this.UsersAccounts.Count();
            if (ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount {Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        }
#endif

        public DbSet<Member> Members { set; get; }
        public DbSet<Account> Accounts { set; get; }
        public DbSet<Loan> Loans { set; get; }
        public DbSet<PaymentHistory> PaymentHistories { set; get; }
        public DbSet<LoanPaymentHistory> LoanPaymentHistories { set; get; }
        public DbSet<UsersAccount> UsersAccounts { set; get; }
    }
}
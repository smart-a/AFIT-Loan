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
        public ApplicationDbContext()
        : base("Server=(localdb)\\mssqllocaldb;Database=afit;Trusted_Connection=True;MultipleActiveResultSets=true") { }

        public DbSet<Member> Members { set; get; }
    }
}
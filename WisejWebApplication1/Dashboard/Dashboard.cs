using AFIT_Cooperative.Models;
using System;
using Wisej.Web;

namespace WisejWebApplication1.Dashboard
{
    public partial class Dashboard : Form
    {
        Member _member;
        public Dashboard(Member member)
        {
            InitializeComponent();
            _member = member;
            //btnUser.Text = _member.Email;
        }
    }
}

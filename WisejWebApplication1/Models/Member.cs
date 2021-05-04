using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AFIT_Cooperative.Models
{
    public class Member
    {
        public Member()
        {
            Id = new Guid();
        }

        public Guid Id { set; get; }
        public string StaffNumber { set; get; }
        public string Fullname { set; get; }
        public string Email { set; get; }
        public string Gender { set; get; }
        public string Phone { set; get; }
        public string Password { set; get; }

        public object this[string propertyName]
        {
            get
            {
                // probably faster without reflection:
                // like:  return Properties.Settings.Default.PropertyValues[propertyName] 
                // instead of the following
                Type myType = typeof(Member);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                return myPropInfo.GetValue(this, null);
            }
            set
            {
                Type myType = typeof(Member);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                myPropInfo.SetValue(this, value, null);
            }
        }
    }
}
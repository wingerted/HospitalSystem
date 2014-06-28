using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class department
    {
        public department()
        {
            this.doctors = new List<doctor>();
            this.register_list = new List<register_list>();
            this.withdraw_registration_record = new List<withdraw_registration_record>();
        }

        public long DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescribe { get; set; }
        public string DepartmentType { get; set; }
        public virtual ICollection<doctor> doctors { get; set; }
        public virtual ICollection<register_list> register_list { get; set; }
        public virtual ICollection<withdraw_registration_record> withdraw_registration_record { get; set; }
    }
}

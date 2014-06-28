using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class register_list
    {
        public long RegisterID { get; set; }
        public Nullable<long> PatientID { get; set; }
        public Nullable<long> StaffID { get; set; }
        public Nullable<long> DepartmentID { get; set; }
        public Nullable<long> DoctorID { get; set; }
        public Nullable<System.DateTime> RegisterTime { get; set; }
        public virtual department department { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual patient patient { get; set; }
        public virtual staff staff { get; set; }
    }
}

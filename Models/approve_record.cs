using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class approve_record
    {
        public long ApproveRecordID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> ApplyDoctorID { get; set; }
        public Nullable<long> ApproveDoctorID { get; set; }
        public Nullable<int> MedicineNumber { get; set; }
        public string ApplyReason { get; set; }
        public Nullable<System.DateTime> ApplyTime { get; set; }
        public Nullable<System.DateTime> ApproveTime { get; set; }
        public Nullable<bool> Pass { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual doctor doctor1 { get; set; }
        public virtual medicine medicine { get; set; }
    }
}

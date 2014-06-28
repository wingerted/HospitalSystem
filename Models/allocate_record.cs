using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class allocate_record
    {
        public long AllocateRecordID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> DoctorID { get; set; }
        public string AllocateType { get; set; }
        public Nullable<System.DateTime> AllocateDate { get; set; }
        public string AllocateReason { get; set; }
        public Nullable<int> AllocateNumber { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual medicine medicine { get; set; }
    }
}

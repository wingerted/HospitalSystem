using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class charge_record
    {
        public long ChargeRecordID { get; set; }
        public Nullable<long> PatientID { get; set; }
        public Nullable<long> PrescriptionID { get; set; }
        public Nullable<long> ExamineListID { get; set; }
        public Nullable<long> StaffID { get; set; }
        public Nullable<double> SumPay { get; set; }
        public Nullable<System.DateTime> ChargeDate { get; set; }
        public virtual examine_list examine_list { get; set; }
        public virtual patient patient { get; set; }
        public virtual prescription prescription { get; set; }
        public virtual staff staff { get; set; }
    }
}
